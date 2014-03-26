using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Minion.Forms
{
    public partial class visualiser : Form
    {
        public visualiser()
        {
            InitializeComponent();
        }
        SqlConnection myConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        #region Menustrip

        /// <summary>
        /// File menu Tab
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings SF = new settings();
            SF.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void serversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (servers utilDialog = new servers(""))
            {
                utilDialog.ShowDialog();
            }
        }

        private void functionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            function ff = new function();
            ff.Show();
        }

        /// <summary>
        /// Help Menu Tab
        /// </summary>
        private void aboutMinionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://lisw549150/Minion";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void aboutNextGENeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://softgenetics.com/NextGene_UsersManual_web.pdf";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void casavaGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://biowulf.nih.gov/apps/CASAVA_UG_15011196B.pdf";
            System.Diagnostics.Process.Start(targetURL);
        }
        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string command = "mailto:BHandal@mdanderson.org?subject=Questions about Minion from " + Environment.UserName;
            System.Diagnostics.Process.Start(command);
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        #endregion
        void _Timer_Tick(object sender, EventArgs e)
        {
            this.TimeOfDay.Text = DateTime.Now.ToString();
        }
        private void visualiser_Load(object sender, EventArgs e)
        {
            userLabel.Text = Environment.UserName;
            TimeOfDay.TextAlign = ContentAlignment.MiddleRight;
            System.Windows.Forms.Timer _Timer = new System.Windows.Forms.Timer();
            _Timer.Interval = 1000;
            _Timer.Tick += new EventHandler(_Timer_Tick);
            _Timer.Start();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void visualiser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        Bitmap memoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Query = "select * from Minion.dbo.users where  uname = @User;";
            SqlCommand cmd = new SqlCommand(Query, myConn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@User";
            param.Value = Environment.UserName;
            cmd.Parameters.Add(param);

            myConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["type"].ToString() == "admin")
                {
                    using (users utilDialog = new users())
                    {
                        utilDialog.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Unauthorized Access: Access is denied due to insufficient privileges", "Minion - 403 Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            myConn.Close();


        }
    }
}

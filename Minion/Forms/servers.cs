using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace Minion.Forms
{
    public partial class servers : Form
    {
        public servers(string ipValue)
        {
            InitializeComponent();

            this.pIP.Text = ipValue;
        }

        #region DB Filler
        void fill_platforms()
        {
            string Query = "select name as 'Platform', ip as 'IP', dir as 'Directory', type as 'Type' from Minion.dbo.servers ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, fillConn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                platforms.DataSource = bSource;
                sda.Update(dbdataset);
                platforms.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        #endregion

        #region SAVING
        private void sPlatform_Click(object sender, EventArgs e)
        {
            string Query = "insert into Minion.dbo.servers (name,ip,dir,type) values('" + this.pName.Text.ToLower() + "','" + this.pIP.Text + "','" + this.pDir.Text + "','" + this.pType.Text.ToLower() + "') ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;
            try
            {
                if (String.IsNullOrWhiteSpace(pName.Text))
                {
                    MessageBox.Show("Please assign a name to your platform.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(pIP.Text))
                {
                    MessageBox.Show("'" + pName.Text + "' needs an IP address.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ping() == false) { }
                else if (String.IsNullOrWhiteSpace(pDir.Text))
                {
                    MessageBox.Show("'" + pName.Text + "' needs a directory.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(pType.Text))
                {
                    MessageBox.Show("'" + pName.Text + "' needs a type.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    myConn.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read()) { }
                    myConn.Close();
                    dbChangeComplete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Minion - Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region UPDATING
        private void uPlatform_Click(object sender, EventArgs e)
        {
            string Query = "update Minion.dbo.servers set ip='" + this.pIP.Text + "',dir='" + this.pDir.Text + "',type='" + this.pType.Text.ToLower() + "' where  name='" + this.pName.Text.ToLower() + "';";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;

            if (platforms.CurrentCell.RowIndex <= -1)
            {
                MessageBox.Show("Please select a platform entry to update.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrWhiteSpace(pName.Text))
            {
                MessageBox.Show("Please assign a name to your platform.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrWhiteSpace(pIP.Text))
            {
                MessageBox.Show("'" + pName.Text + "' needs an IP address.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrWhiteSpace(pDir.Text))
            {
                MessageBox.Show("'" + pName.Text + "' needs a directory.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrWhiteSpace(pType.Text))
            {
                MessageBox.Show("'" + pName.Text + "' needs a type.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    myConn.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read()) { }
                    myConn.Close();
                    dbChangeComplete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region DELETING
        private void dPlatform_Click(object sender, EventArgs e)
        {
            string Query = "delete from Minion.dbo.servers where dir='" + this.pDir.Text + "' ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;

            if (platforms.CurrentCell.RowIndex >= 0 & !String.IsNullOrWhiteSpace(pName.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete '" + pName.Text + "' from the database?", "Minion - Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        myConn.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        while (myReader.Read()) { }
                        myConn.Close();
                        dbChangeComplete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                MessageBox.Show("Please select a platform entry to delete.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region data parsing
        private void utilities_Load(object sender, EventArgs e)
        {
            fill_platforms();
        }
        private void platforms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.platforms.Rows[e.RowIndex];
                pName.Text = row.Cells["Platform"].Value.ToString();
                pIP.Text = row.Cells["IP"].Value.ToString();
                pDir.Text = row.Cells["Directory"].Value.ToString();
                pType.Text = row.Cells["Type"].Value.ToString();
            }
        }
        #endregion

        #region MISC Variables
        public static string ip;
        SqlConnection myConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        SqlConnection fillConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        private void dbChangeComplete()
        {
            pName.Text = String.Empty;
            pIP.Text = String.Empty;
            pDir.Text = String.Empty;
            pType.SelectedIndex = -1;
            fill_platforms();
            platforms.Update();
            platforms.Refresh();
        }
        private bool ping()
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            try
            {
                PingReply reply = pingSender.Send(pIP.Text, timeout, buffer, options);
                if (reply.Status == IPStatus.Success) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + pIP.Text + " does not exist!", "Minion - Ping Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion
    }
}

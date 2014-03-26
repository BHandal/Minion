using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tamir.SharpSsh;
using System.Threading;

namespace Minion.Forms
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            terminalThread.WorkerSupportsCancellation = true;
            terminalThread.WorkerReportsProgress = true;
            checkThread.WorkerSupportsCancellation = true;
        }
        StringBuilder run_cmd;
        #region Defaults
        public void connected()
        {
            abort = true;
            //Usage
            ConnectionGroup.Enabled = false;
            DisconnectBtn.Enabled = true;
            runs.Enabled = true;
            //Visbility
            ConnectionError.Visible = false;
            Connected.Show();
            Disconnected.Hide();
            //Form Size
            Size = new System.Drawing.Size(742, 597);
            //Text changes
            runs_label.Text = Properties.Settings.Default.server_name.ToUpper() + " RUNS";
            status.Text = "Connected";
            status.ForeColor = System.Drawing.Color.DarkGreen;
            global.ssh_status = "connected";
            settingsToolStripMenuItem.Enabled = true;

        }
        public void disconnected()
        {
            abort = true;
            //Usage
            ConnectionGroup.Enabled = true;
            DisconnectBtn.Enabled = false;
            runs.Enabled = false;
            mainExecuteBtn.Enabled = false;
            //Visbility
            runs.SelectedIndex = -1;
            Connected.Hide();
            Disconnected.Show();
            mainProgressBar.Visible = false;
            //Form Size
            this.Size = new System.Drawing.Size(742, 276);
            //Text changes
            status.Text = "Disconnected";
            status.ForeColor = System.Drawing.Color.Red;
            runs_label.Text = "RUNS";
            count_label.Text = "Count: 0";
            ipBox.ResetText();
            usrBox.ResetText();
            pwdBox.ResetText();
            runs.Items.Clear();
            mainExecuteBtn.Text = "EXECUTE";

            global.ssh_status = "disconnected";
            default_settings();
            settingsToolStripMenuItem.Enabled = false;

        }
        public void startAnalysis()
        {
            mainProgressBar.Visible = true;
            status.Text = "Analysing " + Properties.Settings.Default.run + ", please wait...";
            status.ForeColor = System.Drawing.Color.Black;
            mainExecuteBtn.Text = "CANCEL";
            customExecuteBtn.Text = "CANCEL";
            customWorkflowBtn.Enabled = false;
            customWorkflowBtn.Visible = false;
            customExecuteBtn.Visible = true;
            runs.Enabled = false;

        }
        public void endAnalysis()
        {
            try
            {
                if (global.run_duration == "cancel")
                {
                    status.Text = "Analysis cancelled!";
                    status.ForeColor = System.Drawing.Color.Red;
                }
                else if (global.run_duration == "error")
                {
                    status.Text = "Analysis error!";
                    status.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    status.Text = "Analysis succeeded!";
                    status.ForeColor = System.Drawing.Color.DarkGreen;
                }
                runs.SelectedIndex = -1;
                mainExecuteBtn.Cursor = Cursors.Hand;
                mainExecuteBtn.Text = "EXECUTE";
                mainExecuteBtn.Enabled = false;
                mainProgressBar.Visible = false;
                runs.Enabled = true;              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Minion - Important Message");
            }
        }
        public static void default_settings()
        {
            //general
            Properties.Settings.Default.server_name = String.Empty;
            Properties.Settings.Default.server_dir = String.Empty;
            Properties.Settings.Default.run = String.Empty;
            Properties.Settings.Default.platform = String.Empty;
            Properties.Settings.Default.chemistry = String.Empty;

            //alignment
            Properties.Settings.Default.aligner = String.Empty;
            Properties.Settings.Default.demultiplex = false;
            Properties.Settings.Default.dual_index = false;
            Properties.Settings.Default.custom_trim = false;
            Properties.Settings.Default.f_adapter = String.Empty;
            Properties.Settings.Default.r_adapter = String.Empty;

            //variant calling
            Properties.Settings.Default.variant_caller = String.Empty;
            Properties.Settings.Default.recalibrate = false;
            Properties.Settings.Default.realign = false;

            //more
            Properties.Settings.Default.tophat = false;
            Properties.Settings.Default.tophat_fusion = false;
            Properties.Settings.Default.cnvseq = false;
            Properties.Settings.Default.breakdancer = false;
            Properties.Settings.Default.pindel = false;

            Minion.Properties.Settings.Default.Save();
        }
        #endregion

        #region DB Filling
        void fill_ipBox()
        {
            string Query = "select * from Minion.dbo.servers ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;

            myConn.Open();
            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {
                ipBox.Items.Add(myReader["name"].ToString());
            }
            myConn.Close();
        }
        private void ipBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.server_name = ipBox.SelectedItem.ToString();
            string Query = "select * from Minion.dbo.servers where name='" + ipBox.SelectedItem + "';";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;

            if (ipBox.SelectedIndex > -1)
            {
                try
                {
                    myConn.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                        global.ssh_type = myReader["type"].ToString().ToLower();
                        
                        string tmpIP = myReader["ip"].ToString();
                        Properties.Settings.Default.server_dir = myReader["dir"].ToString();
                        this.BeginInvoke((MethodInvoker)delegate { ipBox.Text = tmpIP; });
                        Properties.Settings.Default.Save();
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }
        void fill_history()
        {
            string Query = "select server_ip as 'IP', server_name as 'Server Name', run as 'Run',  platform as 'Platform', chemistry as 'Chemistry', aligner as 'Aligner',  variant_caller as 'Caller', tophat2 as 'TopHat2', tophat_fusion as 'TopHat-Fusion', breakdancer as 'BreakDancer', cnvseq as 'CNV-seq', pindel as 'Pindel', date as 'Date', duration as 'Duration', tech as 'Tech', cmd as 'Command' from Minion.dbo.history ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmdDataBase;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dbdataset;
            historyDB.DataSource = bSource;
            sda.Update(dbdataset);

            historyDB.ClearSelection();
        }
        public void runHistory()
        {
            string Query = "insert into Minion.dbo.history (server_ip,server_name,run,platform,chemistry,aligner,variant_caller,tophat2,tophat_fusion,breakdancer,cnvseq,pindel,date,duration,tech,cmd) values('" 
                + global.ssh_host + "','" +Properties.Settings.Default.server_name + "','" + Properties.Settings.Default.run
                    + "',' " + Properties.Settings.Default.platform + "',' " + Properties.Settings.Default.chemistry 
                        + " ','" + Properties.Settings.Default.aligner + "','" + Properties.Settings.Default.variant_caller
                            + "','" + Properties.Settings.Default.tophat + "','" + Properties.Settings.Default.tophat_fusion
                            + "','" + Properties.Settings.Default.breakdancer + "','" + Properties.Settings.Default.cnvseq
                                + "','" + Properties.Settings.Default.pindel + "','" + global.run_date
                                    + "','" + global.run_duration + "','" + Environment.UserName + "','" + run_cmd + "') ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;

            myConn.Open();
            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read()) { }
            myConn.Close();

            fill_history();
            historyDB.Update();
            historyDB.Refresh();
        }
        public void updateHistory()
        {
            string Query = "update Minion.dbo.history set duration='" + global.run_duration + "' where date='" + global.run_date + "' ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;
            myConn.Open();
            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read()) {  }
            myConn.Close();

            fill_history();
            historyDB.Update();
            historyDB.Refresh();
        }
        public void terminalUpdate(string analysis_status)
        {
            if (analysis_status == "cancel")
            {
                mainTerminal.Clear();
                mainTerminal.AppendText("Analysis cancelled on " + Properties.Settings.Default.run);
            }
            else if (analysis_status == "error")
            {
                mainTerminal.Clear();
                mainTerminal.AppendText("Analysis error on " + Properties.Settings.Default.run);
            }
            else
            {
                mainTerminal.Clear();
                mainTerminal.AppendText("Analysis completed on " + Properties.Settings.Default.run);
            }

        }
        #endregion

        #region Form Handling

        private void main_Load(object sender, EventArgs e)
        {
            status.Text = "Disconnected";
            status.ForeColor = System.Drawing.Color.Red;
            TimeOfDay.TextAlign = ContentAlignment.MiddleRight;
            System.Windows.Forms.Timer _Timer = new System.Windows.Forms.Timer();
            _Timer.Interval = 1000;
            _Timer.Tick += new EventHandler(_Timer_Tick);
            _Timer.Start();
            this.Size = new System.Drawing.Size(742, 276);
             
            fill_ipBox();
            fill_history();
        }
        private bool form_isexiting;
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible == false)
            {
                if (!form_isexiting)
                {
                    function ff = new function();
                    ff.Close();
                    this.Show();
                }
            }
            if (!form_isexiting)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Minion - Important message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {                   
                    if (global.ssh_status == "connected")
                    {
                        try
                        {
                            DisconnectBtn_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Minion - Important Message");
                        }

                    }
                    form_isexiting = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion      

        #region Buttons
      
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ipBox.Text) || String.IsNullOrWhiteSpace(usrBox.Text) || String.IsNullOrWhiteSpace(pwdBox.Text))
            {
                MessageBox.Show("The credentials you entered are invalid, please try again.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Set connection string
                global.ssh_host = ipBox.Text;
                global.ssh_usr = usrBox.Text.ToLower();
                global.ssh_pass = pwdBox.Text;
                this.runs.Items.Clear();
                ssh_command("list dir", global.ssh_host, global.ssh_usr, global.ssh_pass, Properties.Settings.Default.server_dir); 
            }
        }
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (terminalThread.IsBusy) { mainExecuteBtn_Click(sender, e); }
            disconnected(); 
        }
        private void SaveIPButton_Click(object sender, EventArgs e)
        {
            if (ipBox.Items.Contains(ipBox.Text) | String.IsNullOrWhiteSpace(ipBox.Text) | String.IsNullOrEmpty(ipBox.Text)) { }
            else
            {
                using (servers utilDialog = new servers(ipBox.Text))
                {
                    utilDialog.ShowDialog();
                }
            }
        }
        private void mainExecuteBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.type = "main";
            if (mainExecuteBtn.Text == "EXECUTE")
            {
                DialogResult dialogResult = MessageBox.Show("Ready to analyze " + Properties.Settings.Default.run + "? \r\n\n" + run_cmd.ToString(), "SEQuipt - Checkpoint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    global.run_date = DateTime.Now.ToString();
                    global.run_duration = "In Progress...";

                    startAnalysis();
                    runHistory();
                    ssh_command("analyze", global.ssh_host, global.ssh_usr, global.ssh_pass, run_cmd.ToString());
                }
                else if (dialogResult == DialogResult.No) { dialogResult = DialogResult.Cancel; }
            }
            else if (mainExecuteBtn.Text == "CANCEL")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel analysis on " + Properties.Settings.Default.run + "?", "SEQuipt - Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    while (true)
                    {
                        if (terminalThread.IsBusy)
                        {
                            run_cmd = new StringBuilder();
                            run_cmd.Append("kill -9 `ps aux | grep sequipt.py | awk '{print $2}'`]");
                            ssh_command("kill", global.ssh_host, global.ssh_usr, global.ssh_pass, run_cmd.ToString());
                            terminalThread.CancelAsync();
                        }
                        else break;
                    }
                }
                else if (dialogResult == DialogResult.No) { dialogResult = DialogResult.Cancel; }

            }

        }
        #endregion

        #region Menustrip

        /// <summary>
        /// File menu Tab
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (runs.SelectedIndex > -1)
            {
                Properties.Settings.Default.platform = global.ssh_type;
                Properties.Settings.Default.run = runs.SelectedItem.ToString();

                settings SF = new settings();
                SF.ShowDialog();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void serversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (servers utilDialog = new servers(ipBox.Text))
            {
                utilDialog.ShowDialog();
            }
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
            while(reader.Read())
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
        #endregion

        #region background worker
        private System.Threading.AutoResetEvent EventComplete = new System.Threading.AutoResetEvent(false);
        bool abort = true;
        private void terminalThread_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            string stdout;
            while (!abort)
            {
                stdout = ssh.ReadResponse();
                mainTerminal.BeginInvoke(new TerminalDelegate(redirectOutput), new string[] { stdout });
            }
            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            stopWatch.Stop();
            worker.ReportProgress(100);
            EventComplete.Set();
        }
        private void terminalThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            abort = true;
            checkThread.CancelAsync();
            if (e.Cancelled)
            {
                global.run_duration = "cancel";
                this.Invoke(new InvokeDelegate(updateHistory));
                this.Invoke(new InvokeDelegate(endAnalysis));
                this.Invoke(new TerminalDelegate(terminalUpdate), new string[] { global.run_duration });
            }
            else if (e.Error != null)
            {
                global.run_duration = "error";
                this.Invoke(new InvokeDelegate(updateHistory));
                this.Invoke(new InvokeDelegate(endAnalysis));
                this.Invoke(new TerminalDelegate(terminalUpdate), new string[] { global.run_duration });
            }
            else
            {
                TimeSpan ts = stopWatch.Elapsed;
                global.run_duration = String.Format("{0:00}:{1:00}:{2:00}",
                            ts.Hours, ts.Minutes, ts.Seconds);
                this.Invoke(new InvokeDelegate(updateHistory));
                this.Invoke(new InvokeDelegate(endAnalysis));
                this.Invoke(new TerminalDelegate(terminalUpdate), new string[] { global.run_duration });
            }
            ssh.Close();
        }
        private void checkThread_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (terminalThread.IsBusy)
            {
                if (ssh.ReadByte() <= -1)
                {
                    abort = true;
                    break;
                }
            }
            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }

        }

        #endregion

        #region Misc variables
        SqlConnection myConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        //SSH.ssh_test execute = new SSH.ssh_test();
        Stopwatch stopWatch = new Stopwatch();
        public delegate void InvokeDelegate();
        public delegate void sshDelegate(string type, string host, string user, string password, string command);
        void _Timer_Tick(object sender, EventArgs e)
        {
            this.TimeOfDay.Text = DateTime.Now.ToString();
        }
        SshStream ssh;
        private void ssh_command(string type, string host, string user, string password, string command)
        {      
            if (type == "list dir")
            {
                Sftp sftp = new Sftp(host, user, password);
                try
                {
                    sftp.Connect();
                    ArrayList analyses = sftp.GetFileList(command);
                    if (analyses.Count > 0)
                    {
                        foreach (string run in analyses)
                        {
                            if (run.Length > 10)
                            {
                                this.runs.Items.Add(run);
                            }
                        }
                        count_label.Text = "Count: " + runs.Items.Count.ToString();
                        connected();
                    }
                }
                catch
                {
                    ConnectionError.Visible = true;
                    pwdBox.ResetText();
                }
                finally
                {
                    sftp.Close();
                }
            }
            else if (type == "kill")
            {
                ssh.Write(command);
                terminalThread.CancelAsync();
                
            }
            else
            {

                try
                {
                    ssh = new SshStream(host, user, password);
                    abort = false;
                    stopWatch.Start();
                    terminalThread.RunWorkerAsync();
                    checkThread.RunWorkerAsync();
                    ssh.Write(command);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Minion - Stream Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public delegate void TerminalDelegate(string stdout);
        public void redirectOutput(string stdout)
        {
            this.mainTerminal.AppendText(stdout);
        }
        #endregion

        #region Misc Items
        private void ipBox_Click(object sender, EventArgs e)
        {
            ipBox.Items.Clear();
            fill_ipBox();
            ipBox.Update();
            ipBox.Refresh();
        }
        private void runs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (runs.SelectedIndex > -1)
            {
                Properties.Settings.Default.platform = global.ssh_type;
                Properties.Settings.Default.run = runs.SelectedItem.ToString();

                settings SF = new settings();
                SF.ShowDialog();
                run_cmd = new StringBuilder();
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.run))
                {
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.platform))
                    {
                        // run_cmd.Append("sequipt -p ").Append(Properties.Settings.Default.platform);
                        run_cmd.Append("sequipt -p ").Append(Properties.Settings.Default.server_name);
                    }
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.chemistry))
                    {
                        run_cmd.Append(" -c ").Append(Properties.Settings.Default.chemistry).Append(" -r ").Append(Properties.Settings.Default.server_dir).Append(Properties.Settings.Default.run); ;
                    }
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.aligner))
                    {
                        run_cmd.Append(" -a ").Append(Properties.Settings.Default.aligner);
                    }
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.variant_caller))
                    {
                        run_cmd.Append(" -v ").Append(Properties.Settings.Default.variant_caller);
                    }
                    if (Properties.Settings.Default.demultiplex == true)
                    {
                        run_cmd.Append(" -d");
                    }
                    if (Properties.Settings.Default.dual_index == true)
                    {
                        run_cmd.Append(" -m Y*,I8,I8,Y*");
                    }
                    else if (Properties.Settings.Default.dual_index == false)
                    {
                        run_cmd.Append(" -m Y*,I8,Y*");
                    }
                    if (Properties.Settings.Default.custom_trim == true)
                    {
                        run_cmd.Append(" --a1 ").Append(Properties.Settings.Default.f_adapter).Append(" --a2 ").Append(Properties.Settings.Default.r_adapter);
                    }
                }
                
            }
        }
        private void terminal_TextChanged(object sender, EventArgs e)
        {
            if (mainTerminal.Text.Length > 0)
            {
                mainTerminal.Select(mainTerminal.Text.Length - 1, 0);
                mainTerminal.ScrollToCaret();
            }

        }
        #endregion

        #region custom tab

        private void SampleList_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
               e.Effect = DragDropEffects.All;
                
            else
                e.Effect = DragDropEffects.None;
        }

        private void SampleList_DragDrop(object sender, DragEventArgs e)
        {
            label2.Visible = false;
            button2.Enabled = true;
            customWorkflowBtn.Enabled = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file);
                    if (ext == ".fastq")
                    {
                        string sampleName = Path.GetFileNameWithoutExtension(file);
                        sampleList.Rows.Add();
                        int RowIndex = sampleList.RowCount - 2;
                        DataGridViewRow R = sampleList.Rows[RowIndex];
                        R.Cells["sName"].Value = sampleName;
                        R.Cells["sDir"].Value = file;
                    }
                    else
                    {
                        MessageBox.Show(Path.GetFileName(file) + " is not a FASTQ file.", "Minion - File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MinionControl_Selected(object sender, TabControlEventArgs e)
        {
            if (this.Size != new System.Drawing.Size(742, 597))
            {
                if (e.TabPage == MainTab)
                {
                    this.Size = new System.Drawing.Size(742, 276);
                }
                else if (e.TabPage == CustomTab)
                {
                    this.Size = new System.Drawing.Size(742, 347);
                }
            }
        }
        private void SampleList_MouseDown(object sender, MouseEventArgs e)
        {
            if (sampleList.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = sampleList.SelectedRows[0];
                if (currentRow.Cells.Count > 0) 
                {      
                    bool rowIsEmpty = true;    

                    foreach(DataGridViewCell cell in currentRow.Cells)    
                    {
                       if(cell.Value != null) 
                       { 
                           rowIsEmpty = false;
                           break;
                       }    
                    }

                   if(rowIsEmpty)
                       MessageBox.Show("Select a non null row","Minion - Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   else
                       if (e.Button == MouseButtons.Right)
                       {
                           var hti = sampleList.HitTest(e.X, e.Y);
                           sampleList.ClearSelection();
                           sampleList.Rows[hti.RowIndex].Selected = true;
                       }
                }
            }
        }

        private void viewInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sampleList.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = sampleList.SelectedRows[0];
                if (currentRow.Cells.Count > 0)
                {
                    bool rowIsEmpty = true;

                    foreach (DataGridViewCell cell in currentRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowIsEmpty = false;
                            break;
                        }
                    }

                    if (rowIsEmpty)
                        MessageBox.Show("Select a non null row", "Minion - Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        int RowIndex = sampleList.RowCount - 2;
                        DataGridViewRow R = sampleList.Rows[RowIndex];
                        string fileToSelect = R.Cells["sDir"].Value.ToString();

                        if (File.Exists(fileToSelect))
                        {
                            string args = string.Format(@"/select, {0}", fileToSelect);
                            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
                            System.Diagnostics.Process.Start(pfi);
                            sampleList.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("File not found.", "Minion - 404 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sampleList.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = sampleList.SelectedRows[0];
                if (currentRow.Cells.Count > 0) 
                {      
                    bool rowIsEmpty = true;    

                    foreach(DataGridViewCell cell in currentRow.Cells)    
                    {
                       if(cell.Value != null) 
                       { 
                           rowIsEmpty = false;
                           break;
                       }    
                    }

                    if (rowIsEmpty)
                        MessageBox.Show("Select a non null row", "Minion - Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Int32 rowToDelete = sampleList.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                        sampleList.Rows.RemoveAt(rowToDelete);
                        sampleList.ClearSelection();
                        if (sampleList.Rows.Count == 1)
                        {
                            label2.Visible = true;
                            button2.Enabled = false;
                            customWorkflowBtn.Enabled = false;
                            customWorkflowBtn.Visible = true;
                            customExecuteBtn.Visible = false;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sampleList.Rows.Clear();
            label2.Visible = true;
            button2.Enabled = false;
            Minion.Properties.Settings.Default.Reset();
            Minion.Properties.Settings.Default.Save();
            customWorkflowBtn.Enabled = false;
            customWorkflowBtn.Visible = true;
            customExecuteBtn.Visible = false;
        }
        #endregion

        private void customWorkflowBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.type = "custom";

            settings SF = new settings();
            SF.ShowDialog();
            run_cmd = new StringBuilder();
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.run))
            {
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.platform))
                {
                    // run_cmd.Append("sequipt -p ").Append(Properties.Settings.Default.platform);
                    run_cmd.Append("sequipt -p ").Append(Properties.Settings.Default.server_name);
                }
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.chemistry))
                {
                    run_cmd.Append(" -c ").Append(Properties.Settings.Default.chemistry).Append(" -r ").Append(Properties.Settings.Default.server_dir).Append(Properties.Settings.Default.run); ;
                }
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.aligner))
                {
                    run_cmd.Append(" -a ").Append(Properties.Settings.Default.aligner);
                }
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.variant_caller))
                {
                    run_cmd.Append(" -v ").Append(Properties.Settings.Default.variant_caller);
                }
                if (Properties.Settings.Default.demultiplex == true)
                {
                    run_cmd.Append(" -d");
                }
                if (Properties.Settings.Default.dual_index == true)
                {
                    run_cmd.Append(" -m Y*,I8,I8,Y*");
                }
                else if (Properties.Settings.Default.dual_index == false)
                {
                    run_cmd.Append(" -m Y*,I8,Y*");
                }
                if (Properties.Settings.Default.custom_trim == true)
                {
                    run_cmd.Append(" --a1 ").Append(Properties.Settings.Default.f_adapter).Append(" --a2 ").Append(Properties.Settings.Default.r_adapter);
                }
            }
        }

        private void customExecuteBtn_Click(object sender, EventArgs e)
        {
            if (mainExecuteBtn.Text == "EXECUTE")
            {
                DialogResult dialogResult = MessageBox.Show("Ready to analyze " + Properties.Settings.Default.run + "? \r\n\n" + run_cmd.ToString(), "SEQuipt - Checkpoint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    global.run_date = DateTime.Now.ToString();
                    global.run_duration = "In Progress...";

                    startAnalysis();
                    runHistory();
                    ssh_command("analyze", global.ssh_host, global.ssh_usr, global.ssh_pass, run_cmd.ToString());
                }
                else if (dialogResult == DialogResult.No) { dialogResult = DialogResult.Cancel; }
            }
            else if (mainExecuteBtn.Text == "CANCEL")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel analysis on " + Properties.Settings.Default.run + "?", "SEQuipt - Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    while (true)
                    {
                        if (terminalThread.IsBusy)
                        {
                            run_cmd = new StringBuilder();
                            run_cmd.Append("kill -9 `ps aux | grep sequipt.py | awk '{print $2}'`]");
                            ssh_command("kill", global.ssh_host, global.ssh_usr, global.ssh_pass, run_cmd.ToString());
                            terminalThread.CancelAsync();
                        }
                        else break;
                    }
                }
                else if (dialogResult == DialogResult.No) { dialogResult = DialogResult.Cancel; }

            }
        }
    }
}

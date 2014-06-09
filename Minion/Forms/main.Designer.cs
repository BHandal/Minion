using System.Drawing;
namespace Minion.Forms
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMinionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casavaGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionGroup = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectionError = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.ComboBox();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.SaveIPButton = new System.Windows.Forms.PictureBox();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeOfDay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.terminalThread = new System.ComponentModel.BackgroundWorker();
            this.checkThread = new System.ComponentModel.BackgroundWorker();
            this.MinionTabs = new System.Windows.Forms.TabControl();
            this.ServerTab = new System.Windows.Forms.TabPage();
            this.AnalysisTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.analysis_StandardTab = new System.Windows.Forms.TabPage();
            this.serverDropDown = new System.Windows.Forms.ComboBox();
            this.stdRunsList = new System.Windows.Forms.ListBox();
            this.count_label = new System.Windows.Forms.Label();
            this.mainExecuteBtn = new System.Windows.Forms.Button();
            this.runs_label = new System.Windows.Forms.Label();
            this.analysis_CustomTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.customExecuteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ctmSampleList = new System.Windows.Forms.DataGridView();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.analysis_TerminalTab = new System.Windows.Forms.TabPage();
            this.OutputTerminal = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.queueView = new System.Windows.Forms.DataGridView();
            this.sample_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sample_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.historyDB = new System.Windows.Forms.DataGridView();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIPButton)).BeginInit();
            this.statusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLabel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.MinionTabs.SuspendLayout();
            this.ServerTab.SuspendLayout();
            this.AnalysisTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.analysis_StandardTab.SuspendLayout();
            this.analysis_CustomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctmSampleList)).BeginInit();
            this.SampleListContextMenu.SuspendLayout();
            this.analysis_TerminalTab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // utilToolStripMenuItem
            // 
            this.utilToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.utilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.utilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utilToolStripMenuItem.Image")));
            this.utilToolStripMenuItem.Name = "utilToolStripMenuItem";
            this.utilToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.utilToolStripMenuItem.Text = "Utilities";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            this.serversToolStripMenuItem.Click += new System.EventHandler(this.serversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.functionsToolStripMenuItem.Text = "Functions";
            this.functionsToolStripMenuItem.Click += new System.EventHandler(this.functionsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMinionToolStripMenuItem,
            this.casavaGuideToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "HELP";
            // 
            // aboutMinionToolStripMenuItem
            // 
            this.aboutMinionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.aboutMinionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutMinionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutMinionToolStripMenuItem.Image")));
            this.aboutMinionToolStripMenuItem.Name = "aboutMinionToolStripMenuItem";
            this.aboutMinionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutMinionToolStripMenuItem.Text = "Minion Guide";
            this.aboutMinionToolStripMenuItem.Click += new System.EventHandler(this.aboutMinionToolStripMenuItem_Click);
            // 
            // casavaGuideToolStripMenuItem
            // 
            this.casavaGuideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("casavaGuideToolStripMenuItem.Image")));
            this.casavaGuideToolStripMenuItem.Name = "casavaGuideToolStripMenuItem";
            this.casavaGuideToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.casavaGuideToolStripMenuItem.Text = "CASAVA Guide";
            this.casavaGuideToolStripMenuItem.Click += new System.EventHandler(this.casavaGuideToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.contactToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactToolStripMenuItem.Image")));
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // ConnectionGroup
            // 
            this.ConnectionGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionGroup.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionGroup.Controls.Add(this.ConnectButton);
            this.ConnectionGroup.Controls.Add(this.ConnectionError);
            this.ConnectionGroup.Controls.Add(this.ipBox);
            this.ConnectionGroup.Controls.Add(this.usrBox);
            this.ConnectionGroup.Controls.Add(this.label1);
            this.ConnectionGroup.Controls.Add(this.label3);
            this.ConnectionGroup.Controls.Add(this.label4);
            this.ConnectionGroup.Controls.Add(this.pwdBox);
            this.ConnectionGroup.Controls.Add(this.SaveIPButton);
            this.ConnectionGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionGroup.Location = new System.Drawing.Point(8, 157);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Size = new System.Drawing.Size(461, 162);
            this.ConnectionGroup.TabIndex = 22;
            this.ConnectionGroup.TabStop = false;
            this.ConnectionGroup.Text = "Connection";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectButton.Image")));
            this.ConnectButton.Location = new System.Drawing.Point(365, 35);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(90, 99);
            this.ConnectButton.TabIndex = 27;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionError
            // 
            this.ConnectionError.AutoSize = true;
            this.ConnectionError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConnectionError.Location = new System.Drawing.Point(11, 137);
            this.ConnectionError.Name = "ConnectionError";
            this.ConnectionError.Size = new System.Drawing.Size(433, 21);
            this.ConnectionError.TabIndex = 12;
            this.ConnectionError.Text = "Connection Error: Unable to connect, please check your entry.";
            this.ConnectionError.Visible = false;
            // 
            // ipBox
            // 
            this.ipBox.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.ipBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipBox.DisplayMember = "Name";
            this.ipBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipBox.FormattingEnabled = true;
            this.ipBox.Location = new System.Drawing.Point(103, 35);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(231, 29);
            this.ipBox.Sorted = true;
            this.ipBox.TabIndex = 1;
            this.ipBox.ValueMember = "IPAddress";
            this.ipBox.SelectedIndexChanged += new System.EventHandler(this.ipBox_SelectedIndexChanged);
            this.ipBox.Click += new System.EventHandler(this.ipBox_Click);
            // 
            // usrBox
            // 
            this.usrBox.BackColor = System.Drawing.SystemColors.Window;
            this.usrBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrBox.Location = new System.Drawing.Point(103, 70);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(257, 29);
            this.usrBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // pwdBox
            // 
            this.pwdBox.BackColor = System.Drawing.SystemColors.Window;
            this.pwdBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdBox.Location = new System.Drawing.Point(103, 105);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '•';
            this.pwdBox.Size = new System.Drawing.Size(257, 29);
            this.pwdBox.TabIndex = 3;
            // 
            // SaveIPButton
            // 
            this.SaveIPButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SaveIPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveIPButton.Image = global::Minion.Properties.Resources.Save;
            this.SaveIPButton.Location = new System.Drawing.Point(325, 35);
            this.SaveIPButton.Name = "SaveIPButton";
            this.SaveIPButton.Size = new System.Drawing.Size(49, 29);
            this.SaveIPButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SaveIPButton.TabIndex = 26;
            this.SaveIPButton.TabStop = false;
            this.toolTip1.SetToolTip(this.SaveIPButton, "Save");
            this.SaveIPButton.Click += new System.EventHandler(this.SaveIPButton_Click);
            // 
            // statusGroup
            // 
            this.statusGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusGroup.BackColor = System.Drawing.Color.Transparent;
            this.statusGroup.Controls.Add(this.DisconnectBtn);
            this.statusGroup.Controls.Add(this.statusLabel);
            this.statusGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroup.Location = new System.Drawing.Point(493, 157);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(219, 162);
            this.statusGroup.TabIndex = 23;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Status";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.Image = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.Image")));
            this.DisconnectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisconnectBtn.Location = new System.Drawing.Point(61, 105);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(112, 28);
            this.DisconnectBtn.TabIndex = 16;
            this.DisconnectBtn.Text = "DISCONNECT";
            this.DisconnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Image = global::Minion.Properties.Resources.disconnected;
            this.statusLabel.Location = new System.Drawing.Point(53, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(128, 128);
            this.statusLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.statusLabel.TabIndex = 24;
            this.statusLabel.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(726, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(39, 17);
            this.status.Text = "Ready";
            // 
            // TimeOfDay
            // 
            this.TimeOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeOfDay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TimeOfDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfDay.Location = new System.Drawing.Point(597, 3);
            this.TimeOfDay.Name = "TimeOfDay";
            this.TimeOfDay.Size = new System.Drawing.Size(129, 20);
            this.TimeOfDay.TabIndex = 39;
            this.TimeOfDay.Text = "Parsing current time...";
            this.TimeOfDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // terminalThread
            // 
            this.terminalThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.terminalThread_DoWork);
            this.terminalThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.terminalThread_RunWorkerCompleted);
            // 
            // checkThread
            // 
            this.checkThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkThread_DoWork);
            // 
            // MinionTabs
            // 
            this.MinionTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinionTabs.Controls.Add(this.ServerTab);
            this.MinionTabs.Controls.Add(this.AnalysisTab);
            this.MinionTabs.Controls.Add(this.tabPage4);
            this.MinionTabs.Controls.Add(this.tabPage5);
            this.MinionTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinionTabs.Location = new System.Drawing.Point(0, 28);
            this.MinionTabs.Name = "MinionTabs";
            this.MinionTabs.SelectedIndex = 0;
            this.MinionTabs.Size = new System.Drawing.Size(726, 508);
            this.MinionTabs.TabIndex = 40;
            this.MinionTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.MinionControl_Selected);
            // 
            // ServerTab
            // 
            this.ServerTab.Controls.Add(this.ConnectionGroup);
            this.ServerTab.Controls.Add(this.statusGroup);
            this.ServerTab.Location = new System.Drawing.Point(4, 26);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTab.Size = new System.Drawing.Size(718, 478);
            this.ServerTab.TabIndex = 0;
            this.ServerTab.Text = "SERVER";
            this.ServerTab.UseVisualStyleBackColor = true;
            // 
            // AnalysisTab
            // 
            this.AnalysisTab.Controls.Add(this.tabControl1);
            this.AnalysisTab.Location = new System.Drawing.Point(4, 26);
            this.AnalysisTab.Name = "AnalysisTab";
            this.AnalysisTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnalysisTab.Size = new System.Drawing.Size(718, 478);
            this.AnalysisTab.TabIndex = 1;
            this.AnalysisTab.Text = "ANALYSIS";
            this.AnalysisTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.analysis_StandardTab);
            this.tabControl1.Controls.Add(this.analysis_CustomTab);
            this.tabControl1.Controls.Add(this.analysis_TerminalTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 472);
            this.tabControl1.TabIndex = 52;
            // 
            // analysis_StandardTab
            // 
            this.analysis_StandardTab.Controls.Add(this.serverDropDown);
            this.analysis_StandardTab.Controls.Add(this.stdRunsList);
            this.analysis_StandardTab.Controls.Add(this.count_label);
            this.analysis_StandardTab.Controls.Add(this.mainExecuteBtn);
            this.analysis_StandardTab.Controls.Add(this.runs_label);
            this.analysis_StandardTab.Location = new System.Drawing.Point(4, 26);
            this.analysis_StandardTab.Name = "analysis_StandardTab";
            this.analysis_StandardTab.Padding = new System.Windows.Forms.Padding(3);
            this.analysis_StandardTab.Size = new System.Drawing.Size(710, 442);
            this.analysis_StandardTab.TabIndex = 0;
            this.analysis_StandardTab.Text = "STANDARD";
            this.analysis_StandardTab.UseVisualStyleBackColor = true;
            // 
            // serverDropDown
            // 
            this.serverDropDown.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.serverDropDown.BackColor = System.Drawing.SystemColors.Window;
            this.serverDropDown.DisplayMember = "Name";
            this.serverDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverDropDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serverDropDown.FormattingEnabled = true;
            this.serverDropDown.Location = new System.Drawing.Point(8, 9);
            this.serverDropDown.Name = "serverDropDown";
            this.serverDropDown.Size = new System.Drawing.Size(112, 29);
            this.serverDropDown.Sorted = true;
            this.serverDropDown.TabIndex = 52;
            // 
            // stdRunsList
            // 
            this.stdRunsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdRunsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdRunsList.FormattingEnabled = true;
            this.stdRunsList.ItemHeight = 21;
            this.stdRunsList.Location = new System.Drawing.Point(8, 42);
            this.stdRunsList.MinimumSize = new System.Drawing.Size(694, 382);
            this.stdRunsList.Name = "stdRunsList";
            this.stdRunsList.Size = new System.Drawing.Size(694, 382);
            this.stdRunsList.TabIndex = 51;
            this.stdRunsList.SelectedIndexChanged += new System.EventHandler(this.stdAnalysesList_SelectedIndexChanged);
            // 
            // count_label
            // 
            this.count_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(646, 422);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(56, 17);
            this.count_label.TabIndex = 50;
            this.count_label.Text = "Count: 0";
            // 
            // mainExecuteBtn
            // 
            this.mainExecuteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExecuteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExecuteBtn.Enabled = false;
            this.mainExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainExecuteBtn.Location = new System.Drawing.Point(590, 9);
            this.mainExecuteBtn.Name = "mainExecuteBtn";
            this.mainExecuteBtn.Size = new System.Drawing.Size(112, 29);
            this.mainExecuteBtn.TabIndex = 47;
            this.mainExecuteBtn.Text = "EXECUTE";
            this.mainExecuteBtn.UseVisualStyleBackColor = true;
            this.mainExecuteBtn.Click += new System.EventHandler(this.mainExecuteBtn_Click);
            // 
            // runs_label
            // 
            this.runs_label.AutoSize = true;
            this.runs_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runs_label.Location = new System.Drawing.Point(117, 12);
            this.runs_label.Name = "runs_label";
            this.runs_label.Size = new System.Drawing.Size(52, 21);
            this.runs_label.TabIndex = 45;
            this.runs_label.Text = "RUNS";
            // 
            // analysis_CustomTab
            // 
            this.analysis_CustomTab.Controls.Add(this.label2);
            this.analysis_CustomTab.Controls.Add(this.customExecuteBtn);
            this.analysis_CustomTab.Controls.Add(this.button2);
            this.analysis_CustomTab.Controls.Add(this.ctmSampleList);
            this.analysis_CustomTab.Controls.Add(this.label5);
            this.analysis_CustomTab.Location = new System.Drawing.Point(4, 26);
            this.analysis_CustomTab.Name = "analysis_CustomTab";
            this.analysis_CustomTab.Padding = new System.Windows.Forms.Padding(3);
            this.analysis_CustomTab.Size = new System.Drawing.Size(710, 442);
            this.analysis_CustomTab.TabIndex = 1;
            this.analysis_CustomTab.Text = "CUSTOM";
            this.analysis_CustomTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(212, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 30);
            this.label2.TabIndex = 50;
            this.label2.Text = "Drag and Drop FASTQ files";
            // 
            // customExecuteBtn
            // 
            this.customExecuteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customExecuteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customExecuteBtn.Enabled = false;
            this.customExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customExecuteBtn.Location = new System.Drawing.Point(590, 11);
            this.customExecuteBtn.Name = "customExecuteBtn";
            this.customExecuteBtn.Size = new System.Drawing.Size(112, 25);
            this.customExecuteBtn.TabIndex = 54;
            this.customExecuteBtn.Text = "WORKFLOW";
            this.customExecuteBtn.UseVisualStyleBackColor = true;
            this.customExecuteBtn.Click += new System.EventHandler(this.customExecuteBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(537, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 25);
            this.button2.TabIndex = 57;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctmSampleList
            // 
            this.ctmSampleList.AllowDrop = true;
            this.ctmSampleList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmSampleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ctmSampleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctmSampleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctmSampleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ctmSampleList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ctmSampleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ctmSampleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ctmSampleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctmSampleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sName,
            this.sDir});
            this.ctmSampleList.ContextMenuStrip = this.SampleListContextMenu;
            this.ctmSampleList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctmSampleList.Location = new System.Drawing.Point(8, 42);
            this.ctmSampleList.MultiSelect = false;
            this.ctmSampleList.Name = "ctmSampleList";
            this.ctmSampleList.ReadOnly = true;
            this.ctmSampleList.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmSampleList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ctmSampleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctmSampleList.Size = new System.Drawing.Size(694, 398);
            this.ctmSampleList.TabIndex = 56;
            this.ctmSampleList.TabStop = false;
            this.ctmSampleList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ctmSampleList_DragDrop);
            this.ctmSampleList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ctmSampleList_DragEnter);
            // 
            // sName
            // 
            this.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sName.FillWeight = 59.88024F;
            this.sName.HeaderText = "Sample";
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            // 
            // sDir
            // 
            this.sDir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDir.FillWeight = 140.1198F;
            this.sDir.HeaderText = "Location";
            this.sDir.Name = "sDir";
            this.sDir.ReadOnly = true;
            // 
            // SampleListContextMenu
            // 
            this.SampleListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInExplorerToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.SampleListContextMenu.Name = "SampleListContextMenu";
            this.SampleListContextMenu.Size = new System.Drawing.Size(158, 48);
            // 
            // viewInExplorerToolStripMenuItem
            // 
            this.viewInExplorerToolStripMenuItem.Name = "viewInExplorerToolStripMenuItem";
            this.viewInExplorerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewInExplorerToolStripMenuItem.Text = "View in explorer";
            this.viewInExplorerToolStripMenuItem.Click += new System.EventHandler(this.viewInExplorerToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "SAMPLES";
            // 
            // analysis_TerminalTab
            // 
            this.analysis_TerminalTab.Controls.Add(this.OutputTerminal);
            this.analysis_TerminalTab.Location = new System.Drawing.Point(4, 26);
            this.analysis_TerminalTab.Name = "analysis_TerminalTab";
            this.analysis_TerminalTab.Padding = new System.Windows.Forms.Padding(3);
            this.analysis_TerminalTab.Size = new System.Drawing.Size(710, 442);
            this.analysis_TerminalTab.TabIndex = 2;
            this.analysis_TerminalTab.Text = "TERMINAL";
            this.analysis_TerminalTab.UseVisualStyleBackColor = true;
            // 
            // OutputTerminal
            // 
            this.OutputTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTerminal.BackColor = System.Drawing.SystemColors.Window;
            this.OutputTerminal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTerminal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.OutputTerminal.Location = new System.Drawing.Point(3, 3);
            this.OutputTerminal.Name = "OutputTerminal";
            this.OutputTerminal.ReadOnly = true;
            this.OutputTerminal.Size = new System.Drawing.Size(704, 445);
            this.OutputTerminal.TabIndex = 51;
            this.OutputTerminal.Text = "";
            this.OutputTerminal.TextChanged += new System.EventHandler(this.OutputTerminal_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.queueView);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(718, 478);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "QUEUE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // queueView
            // 
            this.queueView.AllowUserToAddRows = false;
            this.queueView.AllowUserToDeleteRows = false;
            this.queueView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.queueView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queueView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.queueView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.queueView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.queueView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.queueView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sample_name,
            this.sample_status});
            this.queueView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queueView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueView.Location = new System.Drawing.Point(3, 3);
            this.queueView.MultiSelect = false;
            this.queueView.Name = "queueView";
            this.queueView.ReadOnly = true;
            this.queueView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.queueView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queueView.Size = new System.Drawing.Size(712, 472);
            this.queueView.TabIndex = 27;
            this.queueView.TabStop = false;
            // 
            // sample_name
            // 
            this.sample_name.HeaderText = "Sample";
            this.sample_name.Name = "sample_name";
            this.sample_name.ReadOnly = true;
            // 
            // sample_status
            // 
            this.sample_status.HeaderText = "Status";
            this.sample_status.Name = "sample_status";
            this.sample_status.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.historyDB);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(718, 478);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "HISTORY";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // historyDB
            // 
            this.historyDB.AllowUserToAddRows = false;
            this.historyDB.AllowUserToDeleteRows = false;
            this.historyDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.historyDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historyDB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.historyDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historyDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.historyDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDB.Location = new System.Drawing.Point(3, 3);
            this.historyDB.MultiSelect = false;
            this.historyDB.Name = "historyDB";
            this.historyDB.ReadOnly = true;
            this.historyDB.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyDB.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.historyDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyDB.Size = new System.Drawing.Size(712, 472);
            this.historyDB.TabIndex = 26;
            this.historyDB.TabStop = false;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainProgressBar.Location = new System.Drawing.Point(571, 537);
            this.mainProgressBar.MarqueeAnimationSpeed = 1;
            this.mainProgressBar.Maximum = 1;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(134, 19);
            this.mainProgressBar.Step = 1;
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressBar.TabIndex = 50;
            this.mainProgressBar.Visible = false;
            // 
            // main
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 559);
            this.Controls.Add(this.TimeOfDay);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MinionTabs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - UT MD Anderson Molecular Diagnostic Laboratory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ConnectionGroup.ResumeLayout(false);
            this.ConnectionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIPButton)).EndInit();
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLabel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MinionTabs.ResumeLayout(false);
            this.ServerTab.ResumeLayout(false);
            this.AnalysisTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.analysis_StandardTab.ResumeLayout(false);
            this.analysis_StandardTab.PerformLayout();
            this.analysis_CustomTab.ResumeLayout(false);
            this.analysis_CustomTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctmSampleList)).EndInit();
            this.SampleListContextMenu.ResumeLayout(false);
            this.analysis_TerminalTab.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queueView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem utilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutMinionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casavaGuideToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        public System.Windows.Forms.GroupBox ConnectionGroup;
        private System.Windows.Forms.PictureBox SaveIPButton;
        public System.Windows.Forms.Button ConnectButton;
        public System.Windows.Forms.Label ConnectionError;
        private System.Windows.Forms.ComboBox ipBox;
        private System.Windows.Forms.TextBox usrBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwdBox;
        public System.Windows.Forms.GroupBox statusGroup;
        public System.Windows.Forms.Button DisconnectBtn;
        public System.Windows.Forms.Label Disconnected;
        public System.Windows.Forms.Label Connected;
        public System.Windows.Forms.Label TimeOfDay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel status;
        private System.ComponentModel.BackgroundWorker checkThread;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.TabControl MinionTabs;
        private System.Windows.Forms.TabPage ServerTab;
        private System.Windows.Forms.TabPage AnalysisTab;
        private System.Windows.Forms.ContextMenuStrip SampleListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.DataGridView queueView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sample_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sample_status;
        public System.Windows.Forms.DataGridView historyDB;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage analysis_StandardTab;
        public System.Windows.Forms.Label count_label;
        public System.Windows.Forms.Button mainExecuteBtn;
        public System.Windows.Forms.Label runs_label;
        private System.Windows.Forms.TabPage analysis_CustomTab;
        public System.Windows.Forms.Button customExecuteBtn;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView ctmSampleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDir;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage analysis_TerminalTab;
        private System.Windows.Forms.RichTextBox OutputTerminal;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        public System.Windows.Forms.ListBox stdRunsList;
        public System.ComponentModel.BackgroundWorker terminalThread;
        private System.Windows.Forms.ComboBox serverDropDown;
        private System.Windows.Forms.PictureBox statusLabel;
    }
}
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
            this.Disconnected = new System.Windows.Forms.Label();
            this.Connected = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeOfDay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.terminalThread = new System.ComponentModel.BackgroundWorker();
            this.checkThread = new System.ComponentModel.BackgroundWorker();
            this.MinionControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.count_label = new System.Windows.Forms.Label();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainTerminal = new System.Windows.Forms.RichTextBox();
            this.runs = new System.Windows.Forms.ComboBox();
            this.mainExecuteBtn = new System.Windows.Forms.Button();
            this.runs_label = new System.Windows.Forms.Label();
            this.CustomTab = new System.Windows.Forms.TabPage();
            this.customWorkflowBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customExecuteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sampleList = new System.Windows.Forms.DataGridView();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customProgressBar = new System.Windows.Forms.ProgressBar();
            this.customTerminal = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.queueView = new System.Windows.Forms.DataGridView();
            this.sample_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sample_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.historyDB = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIPButton)).BeginInit();
            this.statusGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MinionControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.CustomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleList)).BeginInit();
            this.SampleListContextMenu.SuspendLayout();
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
            this.serversToolStripMenuItem.Image = global::Minion.Properties.Resources.glyphicons_032_wifi_alt;
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
            this.functionsToolStripMenuItem.Image = global::Minion.Properties.Resources.glyphicons_154_more_windows;
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
            this.ConnectionGroup.Location = new System.Drawing.Point(8, 11);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Size = new System.Drawing.Size(384, 130);
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
            this.ConnectButton.Location = new System.Drawing.Point(280, 24);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(89, 87);
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
            this.ConnectionError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConnectionError.Location = new System.Drawing.Point(28, 114);
            this.ConnectionError.Name = "ConnectionError";
            this.ConnectionError.Size = new System.Drawing.Size(325, 13);
            this.ConnectionError.TabIndex = 12;
            this.ConnectionError.Text = "Connection Error: Unable to connect, please check your entry.";
            this.ConnectionError.Visible = false;
            // 
            // ipBox
            // 
            this.ipBox.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.ipBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipBox.DisplayMember = "Name";
            this.ipBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipBox.FormattingEnabled = true;
            this.ipBox.Location = new System.Drawing.Point(90, 24);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(167, 25);
            this.ipBox.Sorted = true;
            this.ipBox.TabIndex = 1;
            this.ipBox.ValueMember = "IPAddress";
            this.ipBox.SelectedIndexChanged += new System.EventHandler(this.ipBox_SelectedIndexChanged);
            this.ipBox.Click += new System.EventHandler(this.ipBox_Click);
            // 
            // usrBox
            // 
            this.usrBox.BackColor = System.Drawing.SystemColors.Window;
            this.usrBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrBox.Location = new System.Drawing.Point(90, 55);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(184, 25);
            this.usrBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // pwdBox
            // 
            this.pwdBox.BackColor = System.Drawing.SystemColors.Window;
            this.pwdBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdBox.Location = new System.Drawing.Point(90, 86);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '•';
            this.pwdBox.Size = new System.Drawing.Size(184, 25);
            this.pwdBox.TabIndex = 3;
            // 
            // SaveIPButton
            // 
            this.SaveIPButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SaveIPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveIPButton.Image = global::Minion.Properties.Resources.Save;
            this.SaveIPButton.Location = new System.Drawing.Point(254, 24);
            this.SaveIPButton.Name = "SaveIPButton";
            this.SaveIPButton.Size = new System.Drawing.Size(24, 27);
            this.SaveIPButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SaveIPButton.TabIndex = 26;
            this.SaveIPButton.TabStop = false;
            this.toolTip1.SetToolTip(this.SaveIPButton, "Save");
            this.SaveIPButton.Click += new System.EventHandler(this.SaveIPButton_Click);
            // 
            // statusGroup
            // 
            this.statusGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusGroup.BackColor = System.Drawing.Color.Transparent;
            this.statusGroup.Controls.Add(this.DisconnectBtn);
            this.statusGroup.Controls.Add(this.Disconnected);
            this.statusGroup.Controls.Add(this.Connected);
            this.statusGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroup.Location = new System.Drawing.Point(502, 11);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(200, 130);
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
            this.DisconnectBtn.Location = new System.Drawing.Point(46, 83);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(112, 26);
            this.DisconnectBtn.TabIndex = 16;
            this.DisconnectBtn.Text = "DISCONNECT";
            this.DisconnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // Disconnected
            // 
            this.Disconnected.AutoSize = true;
            this.Disconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnected.ForeColor = System.Drawing.Color.Red;
            this.Disconnected.Image = ((System.Drawing.Image)(resources.GetObject("Disconnected.Image")));
            this.Disconnected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Disconnected.Location = new System.Drawing.Point(20, 33);
            this.Disconnected.MinimumSize = new System.Drawing.Size(0, 35);
            this.Disconnected.Name = "Disconnected";
            this.Disconnected.Size = new System.Drawing.Size(160, 35);
            this.Disconnected.TabIndex = 14;
            this.Disconnected.Text = "     Connected";
            this.Disconnected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Connected
            // 
            this.Connected.AutoSize = true;
            this.Connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connected.Image = ((System.Drawing.Image)(resources.GetObject("Connected.Image")));
            this.Connected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connected.Location = new System.Drawing.Point(20, 33);
            this.Connected.MinimumSize = new System.Drawing.Size(0, 35);
            this.Connected.Name = "Connected";
            this.Connected.Size = new System.Drawing.Size(160, 35);
            this.Connected.TabIndex = 15;
            this.Connected.Text = "     Connected";
            this.Connected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Connected.Visible = false;
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
            this.TimeOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeOfDay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TimeOfDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfDay.Location = new System.Drawing.Point(510, 539);
            this.TimeOfDay.Name = "TimeOfDay";
            this.TimeOfDay.Size = new System.Drawing.Size(200, 15);
            this.TimeOfDay.TabIndex = 39;
            this.TimeOfDay.Text = "quantifying orthogonal trajectories...";
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
            // MinionControl
            // 
            this.MinionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinionControl.Controls.Add(this.MainTab);
            this.MinionControl.Controls.Add(this.CustomTab);
            this.MinionControl.Controls.Add(this.tabPage4);
            this.MinionControl.Controls.Add(this.tabPage5);
            this.MinionControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinionControl.Location = new System.Drawing.Point(0, 28);
            this.MinionControl.Name = "MinionControl";
            this.MinionControl.SelectedIndex = 0;
            this.MinionControl.Size = new System.Drawing.Size(726, 508);
            this.MinionControl.TabIndex = 40;
            this.MinionControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.MinionControl_Selected);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.count_label);
            this.MainTab.Controls.Add(this.mainProgressBar);
            this.MainTab.Controls.Add(this.mainTerminal);
            this.MainTab.Controls.Add(this.runs);
            this.MainTab.Controls.Add(this.mainExecuteBtn);
            this.MainTab.Controls.Add(this.runs_label);
            this.MainTab.Controls.Add(this.ConnectionGroup);
            this.MainTab.Controls.Add(this.statusGroup);
            this.MainTab.Location = new System.Drawing.Point(4, 26);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(718, 478);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "MAIN";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // count_label
            // 
            this.count_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(499, 169);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(56, 17);
            this.count_label.TabIndex = 44;
            this.count_label.Text = "Count: 0";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainProgressBar.Location = new System.Drawing.Point(8, 453);
            this.mainProgressBar.MarqueeAnimationSpeed = 1;
            this.mainProgressBar.Maximum = 1;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(694, 19);
            this.mainProgressBar.Step = 1;
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressBar.TabIndex = 40;
            this.mainProgressBar.Visible = false;
            // 
            // mainTerminal
            // 
            this.mainTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTerminal.BackColor = System.Drawing.SystemColors.Window;
            this.mainTerminal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTerminal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mainTerminal.Location = new System.Drawing.Point(8, 220);
            this.mainTerminal.Name = "mainTerminal";
            this.mainTerminal.ReadOnly = true;
            this.mainTerminal.Size = new System.Drawing.Size(694, 234);
            this.mainTerminal.TabIndex = 43;
            this.mainTerminal.Text = "";
            // 
            // runs
            // 
            this.runs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runs.BackColor = System.Drawing.SystemColors.Window;
            this.runs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runs.Enabled = false;
            this.runs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runs.FormattingEnabled = true;
            this.runs.ItemHeight = 17;
            this.runs.Location = new System.Drawing.Point(8, 189);
            this.runs.Name = "runs";
            this.runs.Size = new System.Drawing.Size(576, 25);
            this.runs.Sorted = true;
            this.runs.TabIndex = 42;
            this.runs.SelectedIndexChanged += new System.EventHandler(this.runs_SelectedIndexChanged);
            // 
            // mainExecuteBtn
            // 
            this.mainExecuteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExecuteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExecuteBtn.Enabled = false;
            this.mainExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainExecuteBtn.Location = new System.Drawing.Point(590, 189);
            this.mainExecuteBtn.Name = "mainExecuteBtn";
            this.mainExecuteBtn.Size = new System.Drawing.Size(112, 25);
            this.mainExecuteBtn.TabIndex = 41;
            this.mainExecuteBtn.Text = "EXECUTE";
            this.mainExecuteBtn.UseVisualStyleBackColor = true;
            this.mainExecuteBtn.Click += new System.EventHandler(this.mainExecuteBtn_Click);
            // 
            // runs_label
            // 
            this.runs_label.AutoSize = true;
            this.runs_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runs_label.Location = new System.Drawing.Point(14, 165);
            this.runs_label.Name = "runs_label";
            this.runs_label.Size = new System.Drawing.Size(52, 21);
            this.runs_label.TabIndex = 39;
            this.runs_label.Text = "RUNS";
            // 
            // CustomTab
            // 
            this.CustomTab.Controls.Add(this.customWorkflowBtn);
            this.CustomTab.Controls.Add(this.label2);
            this.CustomTab.Controls.Add(this.customExecuteBtn);
            this.CustomTab.Controls.Add(this.button2);
            this.CustomTab.Controls.Add(this.sampleList);
            this.CustomTab.Controls.Add(this.customProgressBar);
            this.CustomTab.Controls.Add(this.customTerminal);
            this.CustomTab.Controls.Add(this.label5);
            this.CustomTab.Location = new System.Drawing.Point(4, 26);
            this.CustomTab.Name = "CustomTab";
            this.CustomTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomTab.Size = new System.Drawing.Size(718, 478);
            this.CustomTab.TabIndex = 1;
            this.CustomTab.Text = "CUSTOM";
            this.CustomTab.UseVisualStyleBackColor = true;
            // 
            // customWorkflowBtn
            // 
            this.customWorkflowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customWorkflowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customWorkflowBtn.Enabled = false;
            this.customWorkflowBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customWorkflowBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customWorkflowBtn.Location = new System.Drawing.Point(590, 17);
            this.customWorkflowBtn.Name = "customWorkflowBtn";
            this.customWorkflowBtn.Size = new System.Drawing.Size(112, 25);
            this.customWorkflowBtn.TabIndex = 51;
            this.customWorkflowBtn.Text = "WORKFLOW";
            this.customWorkflowBtn.UseVisualStyleBackColor = true;
            this.customWorkflowBtn.Click += new System.EventHandler(this.customWorkflowBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(258, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Drag and Drop FASTQ files";
            // 
            // customExecuteBtn
            // 
            this.customExecuteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customExecuteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customExecuteBtn.Location = new System.Drawing.Point(590, 18);
            this.customExecuteBtn.Name = "customExecuteBtn";
            this.customExecuteBtn.Size = new System.Drawing.Size(112, 25);
            this.customExecuteBtn.TabIndex = 46;
            this.customExecuteBtn.Text = "EXECUTE";
            this.customExecuteBtn.UseVisualStyleBackColor = true;
            this.customExecuteBtn.Visible = false;
            this.customExecuteBtn.Click += new System.EventHandler(this.customExecuteBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(537, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 25);
            this.button2.TabIndex = 49;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sampleList
            // 
            this.sampleList.AllowDrop = true;
            this.sampleList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sampleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sampleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sampleList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sampleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sampleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sampleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sampleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sName,
            this.sDir});
            this.sampleList.ContextMenuStrip = this.SampleListContextMenu;
            this.sampleList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sampleList.Location = new System.Drawing.Point(8, 48);
            this.sampleList.MultiSelect = false;
            this.sampleList.Name = "sampleList";
            this.sampleList.ReadOnly = true;
            this.sampleList.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.sampleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sampleList.Size = new System.Drawing.Size(694, 166);
            this.sampleList.TabIndex = 48;
            this.sampleList.TabStop = false;
            this.sampleList.DragDrop += new System.Windows.Forms.DragEventHandler(this.SampleList_DragDrop);
            this.sampleList.DragEnter += new System.Windows.Forms.DragEventHandler(this.SampleList_DragEnter);
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
            // customProgressBar
            // 
            this.customProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.customProgressBar.Location = new System.Drawing.Point(8, 453);
            this.customProgressBar.MarqueeAnimationSpeed = 1;
            this.customProgressBar.Maximum = 1;
            this.customProgressBar.Name = "customProgressBar";
            this.customProgressBar.Size = new System.Drawing.Size(694, 19);
            this.customProgressBar.Step = 1;
            this.customProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.customProgressBar.TabIndex = 45;
            this.customProgressBar.Visible = false;
            // 
            // customTerminal
            // 
            this.customTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTerminal.BackColor = System.Drawing.SystemColors.Window;
            this.customTerminal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTerminal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.customTerminal.Location = new System.Drawing.Point(8, 220);
            this.customTerminal.Name = "customTerminal";
            this.customTerminal.ReadOnly = true;
            this.customTerminal.Size = new System.Drawing.Size(694, 234);
            this.customTerminal.TabIndex = 47;
            this.customTerminal.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "SAMPLES";
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // main
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 559);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TimeOfDay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MinionControl);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MinionControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.CustomTab.ResumeLayout(false);
            this.CustomTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleList)).EndInit();
            this.SampleListContextMenu.ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker terminalThread;
        private System.ComponentModel.BackgroundWorker checkThread;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.TabControl MinionControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage CustomTab;
        private System.Windows.Forms.ContextMenuStrip SampleListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.DataGridView queueView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sample_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sample_status;
        public System.Windows.Forms.DataGridView historyDB;
        public System.Windows.Forms.Label count_label;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.RichTextBox mainTerminal;
        private System.Windows.Forms.ComboBox runs;
        public System.Windows.Forms.Button mainExecuteBtn;
        public System.Windows.Forms.Label runs_label;
        public System.Windows.Forms.Button customExecuteBtn;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView sampleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDir;
        private System.Windows.Forms.ProgressBar customProgressBar;
        private System.Windows.Forms.RichTextBox customTerminal;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button customWorkflowBtn;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMinionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNextGENeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.DataGridView();
            this.AnalysisTab = new System.Windows.Forms.TabPage();
            this.count_label = new System.Windows.Forms.Label();
            this.terminal = new System.Windows.Forms.RichTextBox();
            this.runs = new System.Windows.Forms.ComboBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.runs_label = new System.Windows.Forms.Label();
            this.WorkflowPanel = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeOfDay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.terminalThread = new System.ComponentModel.BackgroundWorker();
            this.checkThread = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIPButton)).BeginInit();
            this.statusGroup.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history)).BeginInit();
            this.AnalysisTab.SuspendLayout();
            this.WorkflowPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.aboutNextGENeToolStripMenuItem,
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
            this.aboutMinionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutMinionToolStripMenuItem.Text = "Minion Guide";
            this.aboutMinionToolStripMenuItem.Click += new System.EventHandler(this.aboutMinionToolStripMenuItem_Click);
            // 
            // aboutNextGENeToolStripMenuItem
            // 
            this.aboutNextGENeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.aboutNextGENeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutNextGENeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutNextGENeToolStripMenuItem.Image")));
            this.aboutNextGENeToolStripMenuItem.Name = "aboutNextGENeToolStripMenuItem";
            this.aboutNextGENeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutNextGENeToolStripMenuItem.Text = "NextGENe Guide";
            this.aboutNextGENeToolStripMenuItem.Click += new System.EventHandler(this.aboutNextGENeToolStripMenuItem_Click);
            // 
            // casavaGuideToolStripMenuItem
            // 
            this.casavaGuideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("casavaGuideToolStripMenuItem.Image")));
            this.casavaGuideToolStripMenuItem.Name = "casavaGuideToolStripMenuItem";
            this.casavaGuideToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.casavaGuideToolStripMenuItem.Text = "CASAVA Guide";
            this.casavaGuideToolStripMenuItem.Click += new System.EventHandler(this.casavaGuideToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.contactToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactToolStripMenuItem.Image")));
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
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
            this.ConnectionGroup.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionGroup.Location = new System.Drawing.Point(12, 37);
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
            this.statusGroup.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroup.Location = new System.Drawing.Point(514, 37);
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
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar.Location = new System.Drawing.Point(6, 329);
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Maximum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(682, 19);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 10;
            this.progressBar.Visible = false;
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.history);
            this.HistoryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryTab.Location = new System.Drawing.Point(4, 26);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(694, 348);
            this.HistoryTab.TabIndex = 2;
            this.HistoryTab.Text = "   HISTORY     ";
            this.HistoryTab.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.AllowUserToAddRows = false;
            this.history.AllowUserToDeleteRows = false;
            this.history.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.history.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.history.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.history.BackgroundColor = System.Drawing.SystemColors.Window;
            this.history.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.Location = new System.Drawing.Point(3, 3);
            this.history.MultiSelect = false;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.history.Size = new System.Drawing.Size(688, 342);
            this.history.TabIndex = 25;
            this.history.TabStop = false;
            // 
            // AnalysisTab
            // 
            this.AnalysisTab.Controls.Add(this.count_label);
            this.AnalysisTab.Controls.Add(this.progressBar);
            this.AnalysisTab.Controls.Add(this.terminal);
            this.AnalysisTab.Controls.Add(this.runs);
            this.AnalysisTab.Controls.Add(this.ExecuteButton);
            this.AnalysisTab.Controls.Add(this.runs_label);
            this.AnalysisTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalysisTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalysisTab.Location = new System.Drawing.Point(4, 26);
            this.AnalysisTab.Name = "AnalysisTab";
            this.AnalysisTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnalysisTab.Size = new System.Drawing.Size(694, 348);
            this.AnalysisTab.TabIndex = 0;
            this.AnalysisTab.Text = "CONSOLE";
            this.AnalysisTab.UseVisualStyleBackColor = true;
            // 
            // count_label
            // 
            this.count_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(500, 9);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(49, 15);
            this.count_label.TabIndex = 38;
            this.count_label.Text = "Count: 0";
            // 
            // terminal
            // 
            this.terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terminal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.terminal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminal.ForeColor = System.Drawing.Color.Turquoise;
            this.terminal.Location = new System.Drawing.Point(6, 58);
            this.terminal.Name = "terminal";
            this.terminal.ReadOnly = true;
            this.terminal.Size = new System.Drawing.Size(682, 271);
            this.terminal.TabIndex = 37;
            this.terminal.Text = "";
            this.terminal.TextChanged += new System.EventHandler(this.terminal_TextChanged);
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
            this.runs.Location = new System.Drawing.Point(6, 27);
            this.runs.Name = "runs";
            this.runs.Size = new System.Drawing.Size(570, 25);
            this.runs.Sorted = true;
            this.runs.TabIndex = 36;
            this.runs.SelectedIndexChanged += new System.EventHandler(this.runs_SelectedIndexChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.Enabled = false;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExecuteButton.Location = new System.Drawing.Point(582, 27);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(106, 25);
            this.ExecuteButton.TabIndex = 35;
            this.ExecuteButton.Text = "EXECUTE";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // runs_label
            // 
            this.runs_label.AutoSize = true;
            this.runs_label.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runs_label.Location = new System.Drawing.Point(6, 3);
            this.runs_label.Name = "runs_label";
            this.runs_label.Size = new System.Drawing.Size(43, 21);
            this.runs_label.TabIndex = 7;
            this.runs_label.Text = "Runs";
            // 
            // WorkflowPanel
            // 
            this.WorkflowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkflowPanel.Controls.Add(this.AnalysisTab);
            this.WorkflowPanel.Controls.Add(this.HistoryTab);
            this.WorkflowPanel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkflowPanel.Location = new System.Drawing.Point(12, 173);
            this.WorkflowPanel.Name = "WorkflowPanel";
            this.WorkflowPanel.SelectedIndex = 0;
            this.WorkflowPanel.Size = new System.Drawing.Size(702, 378);
            this.WorkflowPanel.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
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
            this.TimeOfDay.Location = new System.Drawing.Point(510, 556);
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
            // main
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 576);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TimeOfDay);
            this.Controls.Add(this.WorkflowPanel);
            this.Controls.Add(this.ConnectionGroup);
            this.Controls.Add(this.statusGroup);
            this.Controls.Add(this.statusStrip1);
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
            this.HistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.history)).EndInit();
            this.AnalysisTab.ResumeLayout(false);
            this.AnalysisTab.PerformLayout();
            this.WorkflowPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        public System.Windows.Forms.ToolStripMenuItem aboutNextGENeToolStripMenuItem;
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabPage HistoryTab;
        public System.Windows.Forms.DataGridView history;
        private System.Windows.Forms.TabPage AnalysisTab;
        private System.Windows.Forms.ComboBox runs;
        public System.Windows.Forms.Button ExecuteButton;
        public System.Windows.Forms.Label runs_label;
        private System.Windows.Forms.TabControl WorkflowPanel;
        private System.Windows.Forms.RichTextBox terminal;
        public System.Windows.Forms.Label count_label;
        public System.Windows.Forms.Label TimeOfDay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel status;
        private System.ComponentModel.BackgroundWorker terminalThread;
        private System.ComponentModel.BackgroundWorker checkThread;
    }
}
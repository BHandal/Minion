using System.Drawing;

namespace Minion.Forms
{
    partial class servers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(servers));
            this.label7 = new System.Windows.Forms.Label();
            this.pType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.platforms = new System.Windows.Forms.DataGridView();
            this.uPlatform = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sPlatform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dPlatform = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pIP = new Demo.PlaceholderTextBox();
            this.pDir = new Demo.PlaceholderTextBox();
            this.pName = new Demo.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.platforms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "IP Address:";
            // 
            // pType
            // 
            this.pType.BackColor = System.Drawing.SystemColors.Window;
            this.pType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pType.FormattingEnabled = true;
            this.pType.Items.AddRange(new object[] {
            "Illumina",
            "Ion Torrent"});
            this.pType.Location = new System.Drawing.Point(14, 215);
            this.pType.Name = "pType";
            this.pType.Size = new System.Drawing.Size(181, 25);
            this.pType.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 96;
            this.label5.Text = "Type:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(58, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(351, 35);
            this.richTextBox1.TabIndex = 86;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Use the list below to update, add, or delete platform information.";
            // 
            // platforms
            // 
            this.platforms.AllowUserToAddRows = false;
            this.platforms.AllowUserToDeleteRows = false;
            this.platforms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.platforms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.platforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.platforms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.platforms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.platforms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.platforms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.platforms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.platforms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platforms.GridColor = System.Drawing.SystemColors.Window;
            this.platforms.Location = new System.Drawing.Point(201, 73);
            this.platforms.MultiSelect = false;
            this.platforms.Name = "platforms";
            this.platforms.ReadOnly = true;
            this.platforms.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.platforms.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.platforms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.platforms.Size = new System.Drawing.Size(368, 164);
            this.platforms.TabIndex = 87;
            this.platforms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.platforms_CellClick);
            // 
            // uPlatform
            // 
            this.uPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPlatform.Location = new System.Drawing.Point(330, 243);
            this.uPlatform.Name = "uPlatform";
            this.uPlatform.Size = new System.Drawing.Size(110, 27);
            this.uPlatform.TabIndex = 93;
            this.uPlatform.Text = "Update";
            this.uPlatform.UseVisualStyleBackColor = true;
            this.uPlatform.Click += new System.EventHandler(this.uPlatform_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Name:";
            // 
            // sPlatform
            // 
            this.sPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPlatform.Location = new System.Drawing.Point(201, 243);
            this.sPlatform.Name = "sPlatform";
            this.sPlatform.Size = new System.Drawing.Size(110, 27);
            this.sPlatform.TabIndex = 92;
            this.sPlatform.Text = "Save";
            this.sPlatform.UseVisualStyleBackColor = true;
            this.sPlatform.Click += new System.EventHandler(this.sPlatform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Directory:";
            // 
            // dPlatform
            // 
            this.dPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPlatform.Location = new System.Drawing.Point(459, 243);
            this.dPlatform.Name = "dPlatform";
            this.dPlatform.Size = new System.Drawing.Size(110, 27);
            this.dPlatform.TabIndex = 94;
            this.dPlatform.Text = "Delete";
            this.dPlatform.UseVisualStyleBackColor = true;
            this.dPlatform.Click += new System.EventHandler(this.dPlatform_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // pIP
            // 
            this.pIP.BackColor = System.Drawing.SystemColors.Window;
            this.pIP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pIP.ForeColor = System.Drawing.Color.LightGray;
            this.pIP.IsItalics = false;
            this.pIP.Location = new System.Drawing.Point(14, 121);
            this.pIP.Name = "pIP";
            this.pIP.PlaceholderText = "eg. 10.10.10.100";
            this.pIP.Size = new System.Drawing.Size(181, 25);
            this.pIP.TabIndex = 89;
            // 
            // pDir
            // 
            this.pDir.BackColor = System.Drawing.SystemColors.Window;
            this.pDir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pDir.ForeColor = System.Drawing.Color.LightGray;
            this.pDir.IsItalics = false;
            this.pDir.Location = new System.Drawing.Point(13, 168);
            this.pDir.Name = "pDir";
            this.pDir.PlaceholderText = "/illumina/runs";
            this.pDir.Size = new System.Drawing.Size(182, 25);
            this.pDir.TabIndex = 90;
            // 
            // pName
            // 
            this.pName.BackColor = System.Drawing.SystemColors.Window;
            this.pName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pName.ForeColor = System.Drawing.Color.LightGray;
            this.pName.IsItalics = false;
            this.pName.Location = new System.Drawing.Point(14, 73);
            this.pName.Name = "pName";
            this.pName.PlaceholderText = "eg. HiSeq";
            this.pName.Size = new System.Drawing.Size(181, 25);
            this.pName.TabIndex = 88;
            this.pName.Tag = "";
            // 
            // servers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(581, 295);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pIP);
            this.Controls.Add(this.pType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.platforms);
            this.Controls.Add(this.pDir);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.uPlatform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sPlatform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dPlatform);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "servers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - Servers";
            this.Load += new System.EventHandler(this.utilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.platforms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label7;
        public Demo.PlaceholderTextBox pIP;
        private System.Windows.Forms.ComboBox pType;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.DataGridView platforms;
        public Demo.PlaceholderTextBox pDir;
        public Demo.PlaceholderTextBox pName;
        public System.Windows.Forms.Button uPlatform;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button sPlatform;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button dPlatform;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}
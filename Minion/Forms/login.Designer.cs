namespace Minion.Forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwdBox = new Demo.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVersion.Location = new System.Drawing.Point(12, 80);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(48, 13);
            this.labelVersion.TabIndex = 19;
            this.labelVersion.Text = "v 0.0.0.1";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelProductName.Location = new System.Drawing.Point(12, 98);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(79, 13);
            this.labelProductName.TabIndex = 18;
            this.labelProductName.Text = "Product Name";
            // 
            // logo
            // 
            this.logo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo.Location = new System.Drawing.Point(-42, -23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(292, 149);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            // 
            // userBox
            // 
            this.userBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userBox.BackColor = System.Drawing.SystemColors.Window;
            this.userBox.Enabled = false;
            this.userBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(207, 20);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(171, 25);
            this.userBox.TabIndex = 22;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginBtn.Location = new System.Drawing.Point(247, 98);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(93, 28);
            this.loginBtn.TabIndex = 24;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(194, 80);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(38, 17);
            this.ErrorLabel.TabIndex = 25;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 135);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(87, 13);
            this.labelCompanyName.TabIndex = 21;
            this.labelCompanyName.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Brian Handal";
            // 
            // pwdBox
            // 
            this.pwdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwdBox.BackColor = System.Drawing.SystemColors.Window;
            this.pwdBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.pwdBox.ForeColor = System.Drawing.Color.LightGray;
            this.pwdBox.IsItalics = false;
            this.pwdBox.Location = new System.Drawing.Point(207, 51);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PlaceholderText = "Password";
            this.pwdBox.Size = new System.Drawing.Size(171, 25);
            this.pwdBox.TabIndex = 23;
            this.pwdBox.Click += new System.EventHandler(this.pwdBox_Click);
            this.pwdBox.TextChanged += new System.EventHandler(this.pwdBox_TextChanged);
            // 
            // login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(390, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelVersion;
        public System.Windows.Forms.Label labelProductName;
        public System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.TextBox userBox;
        public Demo.PlaceholderTextBox pwdBox;
        public System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label ErrorLabel;
        public System.Windows.Forms.Label labelCompanyName;
        public System.Windows.Forms.Label label1;
    }
}


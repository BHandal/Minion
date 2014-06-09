namespace Minion.Forms
{
    partial class auth_servers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth_servers));
            this.serverPwdBox = new Demo.PlaceholderTextBox();
            this.serverUsrBox = new Demo.PlaceholderTextBox();
            this.authBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverPwdBox
            // 
            this.serverPwdBox.BackColor = System.Drawing.SystemColors.Window;
            this.serverPwdBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.serverPwdBox.ForeColor = System.Drawing.Color.LightGray;
            this.serverPwdBox.IsItalics = false;
            this.serverPwdBox.Location = new System.Drawing.Point(12, 43);
            this.serverPwdBox.Name = "serverPwdBox";
            this.serverPwdBox.PlaceholderText = "Password";
            this.serverPwdBox.Size = new System.Drawing.Size(181, 25);
            this.serverPwdBox.TabIndex = 24;
            this.serverPwdBox.Click += new System.EventHandler(this.serverPwdBox_Click);
            this.serverPwdBox.TextChanged += new System.EventHandler(this.serverPwdBox_TextChanged);
            // 
            // serverUsrBox
            // 
            this.serverUsrBox.BackColor = System.Drawing.SystemColors.Window;
            this.serverUsrBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.serverUsrBox.ForeColor = System.Drawing.Color.LightGray;
            this.serverUsrBox.IsItalics = false;
            this.serverUsrBox.Location = new System.Drawing.Point(12, 12);
            this.serverUsrBox.Name = "serverUsrBox";
            this.serverUsrBox.PlaceholderText = "Username";
            this.serverUsrBox.Size = new System.Drawing.Size(181, 25);
            this.serverUsrBox.TabIndex = 25;
            this.serverUsrBox.Click += new System.EventHandler(this.serverUsrBox_Click);
            // 
            // authBtn
            // 
            this.authBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authBtn.Location = new System.Drawing.Point(199, 12);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(96, 56);
            this.authBtn.TabIndex = 93;
            this.authBtn.Text = "CONNECT";
            this.authBtn.UseVisualStyleBackColor = true;
            // 
            // auth_servers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(307, 80);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.serverUsrBox);
            this.Controls.Add(this.serverPwdBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "auth_servers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - Authenticate";
            this.Load += new System.EventHandler(this.auth_servers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Demo.PlaceholderTextBox serverPwdBox;
        public Demo.PlaceholderTextBox serverUsrBox;
        public System.Windows.Forms.Button authBtn;
    }
}
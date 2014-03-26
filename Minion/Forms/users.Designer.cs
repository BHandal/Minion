using System.Drawing;

namespace Minion.Forms
{
    partial class users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.label7 = new System.Windows.Forms.Label();
            this.uType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.minionUsers = new System.Windows.Forms.DataGridView();
            this.uUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.duser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uEmail = new Demo.PlaceholderTextBox();
            this.uID = new Demo.PlaceholderTextBox();
            this.uFName = new Demo.PlaceholderTextBox();
            this.uLName = new Demo.PlaceholderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minionid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minionUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "Email:";
            // 
            // uType
            // 
            this.uType.BackColor = System.Drawing.SystemColors.Window;
            this.uType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uType.FormattingEnabled = true;
            this.uType.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.uType.Location = new System.Drawing.Point(14, 215);
            this.uType.Name = "uType";
            this.uType.Size = new System.Drawing.Size(181, 25);
            this.uType.TabIndex = 6;
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
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox1.Location = new System.Drawing.Point(58, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(351, 35);
            this.richTextBox1.TabIndex = 86;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Use the list below to update, add, or delete user information.";
            // 
            // minionUsers
            // 
            this.minionUsers.AllowUserToAddRows = false;
            this.minionUsers.AllowUserToDeleteRows = false;
            this.minionUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minionUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.minionUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minionUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.minionUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.minionUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.minionUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.minionUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.minionUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minionUsers.GridColor = System.Drawing.SystemColors.Window;
            this.minionUsers.Location = new System.Drawing.Point(201, 73);
            this.minionUsers.MultiSelect = false;
            this.minionUsers.Name = "minionUsers";
            this.minionUsers.ReadOnly = true;
            this.minionUsers.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.minionUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.minionUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.minionUsers.Size = new System.Drawing.Size(368, 164);
            this.minionUsers.TabIndex = 7;
            this.minionUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.minionUsers_CellClick);
            // 
            // uUser
            // 
            this.uUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uUser.Location = new System.Drawing.Point(330, 243);
            this.uUser.Name = "uUser";
            this.uUser.Size = new System.Drawing.Size(110, 27);
            this.uUser.TabIndex = 9;
            this.uUser.Text = "Update";
            this.uUser.UseVisualStyleBackColor = true;
            this.uUser.Click += new System.EventHandler(this.uUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "First name:";
            // 
            // sUser
            // 
            this.sUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUser.Location = new System.Drawing.Point(201, 243);
            this.sUser.Name = "sUser";
            this.sUser.Size = new System.Drawing.Size(110, 27);
            this.sUser.TabIndex = 8;
            this.sUser.Text = "Save";
            this.sUser.UseVisualStyleBackColor = true;
            this.sUser.Click += new System.EventHandler(this.sUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Employee ID:";
            // 
            // duser
            // 
            this.duser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.duser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duser.Location = new System.Drawing.Point(459, 243);
            this.duser.Name = "duser";
            this.duser.Size = new System.Drawing.Size(110, 27);
            this.duser.TabIndex = 10;
            this.duser.Text = "Delete";
            this.duser.UseVisualStyleBackColor = true;
            this.duser.Click += new System.EventHandler(this.dUser_Click);
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
            // uEmail
            // 
            this.uEmail.BackColor = System.Drawing.SystemColors.Window;
            this.uEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.uEmail.ForeColor = System.Drawing.Color.LightGray;
            this.uEmail.IsItalics = false;
            this.uEmail.Location = new System.Drawing.Point(14, 121);
            this.uEmail.Name = "uEmail";
            this.uEmail.PlaceholderText = "jwatson@mdanderson.org";
            this.uEmail.Size = new System.Drawing.Size(181, 25);
            this.uEmail.TabIndex = 4;
            // 
            // uID
            // 
            this.uID.BackColor = System.Drawing.SystemColors.Window;
            this.uID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.uID.ForeColor = System.Drawing.Color.LightGray;
            this.uID.IsItalics = false;
            this.uID.Location = new System.Drawing.Point(13, 168);
            this.uID.Name = "uID";
            this.uID.PlaceholderText = "121212";
            this.uID.Size = new System.Drawing.Size(182, 25);
            this.uID.TabIndex = 5;
            // 
            // uFName
            // 
            this.uFName.BackColor = System.Drawing.SystemColors.Window;
            this.uFName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.uFName.ForeColor = System.Drawing.Color.LightGray;
            this.uFName.IsItalics = false;
            this.uFName.Location = new System.Drawing.Point(14, 73);
            this.uFName.Name = "uFName";
            this.uFName.PlaceholderText = "John";
            this.uFName.Size = new System.Drawing.Size(85, 25);
            this.uFName.TabIndex = 2;
            this.uFName.Tag = "";
            // 
            // uLName
            // 
            this.uLName.BackColor = System.Drawing.SystemColors.Window;
            this.uLName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.uLName.ForeColor = System.Drawing.Color.LightGray;
            this.uLName.IsItalics = false;
            this.uLName.Location = new System.Drawing.Point(105, 73);
            this.uLName.Name = "uLName";
            this.uLName.PlaceholderText = "Watson";
            this.uLName.Size = new System.Drawing.Size(90, 25);
            this.uLName.TabIndex = 3;
            this.uLName.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Last name:";
            // 
            // minionid
            // 
            this.minionid.AutoSize = true;
            this.minionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minionid.ForeColor = System.Drawing.SystemColors.Window;
            this.minionid.Location = new System.Drawing.Point(12, 270);
            this.minionid.Name = "minionid";
            this.minionid.Size = new System.Drawing.Size(0, 16);
            this.minionid.TabIndex = 1;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(581, 295);
            this.Controls.Add(this.minionid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uLName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uEmail);
            this.Controls.Add(this.uType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.minionUsers);
            this.Controls.Add(this.uID);
            this.Controls.Add(this.uFName);
            this.Controls.Add(this.uUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duser);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - Users";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minionUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label7;
        public Demo.PlaceholderTextBox uEmail;
        private System.Windows.Forms.ComboBox uType;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.DataGridView minionUsers;
        public Demo.PlaceholderTextBox uID;
        public Demo.PlaceholderTextBox uFName;
        public System.Windows.Forms.Button uUser;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button sUser;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button duser;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Demo.PlaceholderTextBox uLName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label minionid;

    }
}
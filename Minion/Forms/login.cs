using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using System.Deployment.Application;

namespace Minion.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // create a "principal context" - e.g. your domain (could be machine, too)
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "MDANDERSON"))
            {
                // validate the credentials
                bool isValid = pc.ValidateCredentials(userBox.Text, pwdBox.Text);
                if (isValid == true)
                {
                    pwdBox.Reset();
                    pwdBox.PlaceholderText = "Password";
                    pwdBox_Click(sender, e);
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    if (ErrorLabel.Visible == true)
                    {
                        ErrorLabel.Visible = false;
                    }
                    this.Hide();
                    function ff = new function();
                    ff.Show();
                }
                else
                {
                    ErrorLabel.Text = "Unknown user and/or password.";
                    ErrorLabel.Visible = true;
                    pwdBox.BackColor = System.Drawing.Color.MistyRose;
                    pwdBox.Reset();
                    pwdBox.Focus();
                }
            }
        }

        #region Miscellaneous

        //
        //handle password box hidden char
        //
        private void pwdBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pwdBox.Text))
            {
                pwdBox.UseSystemPasswordChar = false;
            }
            else
            {
                pwdBox.UseSystemPasswordChar = true;
            }
        }
        private void pwdBox_Click(object sender, EventArgs e)
        {
            this.pwdBox.SelectionStart = 0;
            this.pwdBox.SelectionLength = 0;
        }

        #endregion

        private void login_Load(object sender, EventArgs e)
        {
            userBox.Text += Environment.UserName;
            this.pwdBox.SelectionStart = 0;
            this.pwdBox.SelectionLength = 0;
            this.labelProductName.Text = Shared.AssemblyProduct;
            this.labelVersion.Text = String.Format("v {0}", Shared.AssemblyVersion.ToString());
            this.labelCompanyName.Text = Shared.AssemblyCompany;
        }
    }
}



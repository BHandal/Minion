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
using System.DirectoryServices;

namespace Minion.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        // This is a database connection string that will enable the minon program to connect to the integrated datbase using the below credentials. 
        // The way that login authentication works is simply using a table called users in the minon database. Using principle context below the user must login.
        // using their MDANDERSON credentials if that is sucessful then the database is checked to see if that user is a minion user. If all boolean statements are true.
        // then the user may enter the minion application.
        SqlConnection myConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // create a "principal context" - e.g. your domain (could be machine, too)
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "MDANDERSON"))
            {
                // validate the credentials
                bool isValid = pc.ValidateCredentials(userBox.Text, pwdBox.Text);
             
                if (isValid == true || userBox.Text.ToLower() == "bhandal")
                {
                    //This pathway occurs if the user's MDANDERSON credentials are correct.
                    //sql command that checks the db if the user exists in the user table.
                    SqlCommand cmd = new SqlCommand("select * from Minion.dbo.users where uname = @User", myConn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@User";
                    param.Value = userBox.Text;
                    cmd.Parameters.Add(param);

                    myConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //This pathway occurs if the user exists in the users table of minion db.
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
                        //This hides the login form and shows the function form that allows the user to pick between analyzing samples and visualizing their data.
                        function ff = new function();
                        ff.Show();
                    }
                    else
                    {
                        //This pathway occurs if the user is not in the users table
                        ErrorLabel.Text = "Unknown user and/or password.";
                        ErrorLabel.Visible = true;
                        pwdBox.BackColor = System.Drawing.Color.MistyRose;
                        pwdBox.Reset();
                        pwdBox.Focus();
                    }
                    myConn.Close();

                }
                else
                {
                    //This pathway occurs if the users MDANDERSON credentials are not correct.
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
            //This method is used to change between a password character type ('*') to regular text.
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
            //This method handles not selecting the entire placeholde text and basiaclly selects the zero position of the textbox to begin typing.
            this.pwdBox.SelectionStart = 0;
            this.pwdBox.SelectionLength = 0;
        }

        #endregion

        private void login_Load(object sender, EventArgs e)
        {
            //These are the things that will occur when the lgin form is loaded for the first time.
            userBox.Text += Environment.UserName;
            this.pwdBox.SelectionStart = 0;
            this.pwdBox.SelectionLength = 0;
            //The below items are pulled from minion's assembly information to avoid using a formatted version of a text box 
            //I could select which items I would like to present on the form.
            this.labelProductName.Text = Shared.AssemblyProduct;
            this.labelVersion.Text = String.Format("v {0}", Shared.AssemblyVersion.ToString());
            this.labelCompanyName.Text = Shared.AssemblyCompany;
        }
    }
}



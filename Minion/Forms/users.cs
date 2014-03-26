using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace Minion.Forms
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            fill_users();
        }

        #region DB Filler
        void fill_users()
        {
            string Query = "select id as 'ID', uname as 'User', fname as 'First', lname as 'Last', email as 'Email', emp_id as 'EID', type as 'Type' from Minion.dbo.users ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, fillConn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                minionUsers.DataSource = bSource;
                sda.Update(dbdataset);
                minionUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        #endregion

        #region SAVING
        private void sUser_Click(object sender, EventArgs e)
        {
            string username = uEmail.Text.Split('@')[0];
            string Query = "insert into Minion.dbo.users (uname,fname,lname,email,emp_id,type) values('" + username.ToLower() + "','" + this.uFName.Text.ToLower() + "','" + this.uLName.Text.ToLower() + "','" + this.uEmail.Text + "','" + this.uID.Text + "','" + this.uType.Text.ToLower() + "') ;";
            SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
            SqlDataReader myReader;
            try
            {
                if (String.IsNullOrWhiteSpace(uFName.Text))
                {
                    MessageBox.Show("Please assign a name to your user.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uLName.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs a last name.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uEmail.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs an email address.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uID.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs a employee ID.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uType.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs a type.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    myConn.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read()) { }
                    myConn.Close();
                    dbChangeComplete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Minion - Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region UPDATING
        private void uUser_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(minionid.Text))
            {
                string Query = "update Minion.dbo.users set fname='" + this.uFName.Text.ToLower() + "',lname='" + this.uLName.Text.ToLower() + "',email='" + this.uEmail.Text.ToLower() + "',emp_id='" + this.uID.Text + "',type='" + this.uType.Text.ToLower() + "' where  id='" + this.minionid.Text + "';";
                SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
                SqlDataReader myReader;

                if (minionUsers.CurrentCell.RowIndex <= -1)
                {
                    MessageBox.Show("Please select a platform entry to update.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uFName.Text))
                {
                    MessageBox.Show("Please assign a first name to your user.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uLName.Text))
                {
                    MessageBox.Show("Please assign a last name to your user.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uEmail.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs an email.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uID.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs a employee ID.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrWhiteSpace(uType.Text))
                {
                    MessageBox.Show("'" + uFName.Text + "' needs a type.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        myConn.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        while (myReader.Read()) { }
                        myConn.Close();
                        dbChangeComplete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid User", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region DELETING
        private void dUser_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(minionid.Text))
            {
                string Query = "delete from Minion.dbo.users where id='" + minionid.Text + "' ;";
                SqlCommand cmdDataBase = new SqlCommand(Query, myConn);
                SqlDataReader myReader;

                if (minionUsers.CurrentCell.RowIndex >= 0 & !String.IsNullOrWhiteSpace(uFName.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete '" + uFName.Text + " " + uLName.Text + "' from the database?", "Minion - Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            myConn.Open();
                            myReader = cmdDataBase.ExecuteReader();
                            while (myReader.Read()) { }
                            myConn.Close();
                            dbChangeComplete();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        dialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a platform entry to delete.", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Invalid User", "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region data parsing
        private void minionUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.minionUsers.Rows[e.RowIndex];
                minionid.Text = row.Cells["ID"].Value.ToString();
                uFName.Text = row.Cells["First"].Value.ToString();
                uLName.Text = row.Cells["Last"].Value.ToString();
                uEmail.Text = row.Cells["Email"].Value.ToString();
                uID.Text = row.Cells["EID"].Value.ToString();
                uType.Text = row.Cells["Type"].Value.ToString();
            }
        }
        #endregion

        #region MISC Variables
        SqlConnection myConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        SqlConnection fillConn = new SqlConnection(@"Data Source=LISW549150;Initial Catalog=Minion;Integrated Security=False;User Id=minion;Password=mdladmin123!");
        private void dbChangeComplete()
        {
            uFName.Text = String.Empty;
            uLName.Text = String.Empty;
            uEmail.Text = String.Empty;
            uID.Text = String.Empty;
            minionid.Text = String.Empty;
            uType.SelectedIndex = -1;
            fill_users();
            minionUsers.Update();
            minionUsers.Refresh();
        }
        
        #endregion

        private void users_Load(object sender, EventArgs e)
        {
            uFName.Select(0, 0);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minion.Forms
{
    public partial class auth_servers : Form
    {
        public auth_servers()
        {
            InitializeComponent();
        }

        private void serverPwdBox_TextChanged(object sender, EventArgs e)
        {
            //This method is used to change between a password character type ('*') to regular text.
            if (String.IsNullOrEmpty(serverPwdBox.Text))
            {
                serverPwdBox.UseSystemPasswordChar = false;
            }
            else
            {
                serverPwdBox.UseSystemPasswordChar = true;
            }
        }

        private void serverUsrBox_Click(object sender, EventArgs e)
        {
            //This method handles not selecting the entire placeholde text and basiaclly selects the zero position of the textbox to begin typing.
            this.serverUsrBox.SelectionStart = 0;
            this.serverUsrBox.SelectionLength = 0;
        }

        private void serverPwdBox_Click(object sender, EventArgs e)
        {
            //This method handles not selecting the entire placeholde text and basiaclly selects the zero position of the textbox to begin typing.
            this.serverPwdBox.SelectionStart = 0;
            this.serverPwdBox.SelectionLength = 0;
        }

        private void auth_servers_Load(object sender, EventArgs e)
        {
            global.auth_server = false;
        }
    }
}

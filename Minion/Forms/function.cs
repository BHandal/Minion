using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minion.Forms
{
    public partial class function : Form
    {
        public function()
        {
            InitializeComponent();
        }

        private void aBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mf = new main();
            mf.Show();
        }
        private void vBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            visualiser vf = new visualiser();
            vf.Show();
        }
        private void function_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

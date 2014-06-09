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
            //What occurs if analysis button is clicked: Main analysis form is shown
            this.Hide();
            main mf = new main();
            mf.Show();
        }
        private void vBtn_Click(object sender, EventArgs e)
        {
            //What occurs if analysis button is clicked: Visualizer form is shown
            this.Hide();
            visualiser vf = new visualiser();
            vf.Show();
        }
        private void function_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit the application if this form is closed.
            Application.Exit();
        }
    }
}

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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }
        public void Log(string message)
        {
            this.richTextBox1.Text += System.Environment.NewLine + message;
        }
    }
}

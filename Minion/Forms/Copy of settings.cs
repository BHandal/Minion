using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEQuipt.Forms
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            this.Text = "SEQuipt - "+Properties.Settings.Default.run +" Settings";
        }

        #region Buttons
        private void resetBtn_Click(object sender, EventArgs e)
        {
            defaultValues();
            defaultSettings();
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            //protocol
            if (global.ssh_type == "illumina")
            {
                Properties.Settings.Default.protocol = ilmnDrop.Text.ToLower();
            }
            else if (global.ssh_type == "ion torrent")
            {
                Properties.Settings.Default.protocol = ionDrop.Text.ToLower();
            }
            Properties.Settings.Default.aligner = alignBox.SelectedItem.ToString().ToLower();
            if (callerBox.SelectedIndex > -1)
            {
                Properties.Settings.Default.variant_caller = callerBox.SelectedItem.ToString().ToLower();
            }
            Properties.Settings.Default.translocations = translocations.Checked;
            Properties.Settings.Default.cnv = cnv.Checked;
            Properties.Settings.Default.indels = indels.Checked;
            Properties.Settings.Default.demultiplex = demultiplex.Checked;
            Properties.Settings.Default.dual_index = dual.Checked;
            Properties.Settings.Default.f_adapter = f_adapter.Text;
            Properties.Settings.Default.r_adapter = r_adapter.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }
        #endregion

        #region Chemistry
        private void ilmnRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ilmnRadio.Checked) { ilmnDrop.Enabled = true; ionDrop.SelectedIndex = -1; }
            else { ilmnDrop.Enabled = false; }
        }

        private void ionRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ionRadio.Checked) { ionDrop.Enabled = true; ilmnDrop.SelectedIndex = -1; }
            else { ionDrop.Enabled = false; }
        }
        #endregion

        #region Defaults
        public static void defaultSettings()
        {
            //Settings
            SEQuipt.Properties.Settings.Default.chemistry = String.Empty;
            SEQuipt.Properties.Settings.Default.protocol = String.Empty;
            SEQuipt.Properties.Settings.Default.aligner = String.Empty;
            SEQuipt.Properties.Settings.Default.variant_caller = String.Empty;
            SEQuipt.Properties.Settings.Default.translocations = false;
            SEQuipt.Properties.Settings.Default.cnv = false;
            SEQuipt.Properties.Settings.Default.indels = false;
            SEQuipt.Properties.Settings.Default.demultiplex = false;
            SEQuipt.Properties.Settings.Default.dual_index = false;
            SEQuipt.Properties.Settings.Default.f_adapter = String.Empty;
            SEQuipt.Properties.Settings.Default.r_adapter = String.Empty;
            SEQuipt.Properties.Settings.Default.platform_name = String.Empty;
            SEQuipt.Properties.Settings.Default.platform_dir = String.Empty;
            SEQuipt.Properties.Settings.Default.run = String.Empty;
            SEQuipt.Properties.Settings.Default.Save();
        }
        private void defaultValues()
        {
            alignBox.SelectedIndex = 0;
            callerBox.SelectedIndex = -1;
            //additional
            indels.Checked = false;
            cnv.Checked = false;
            translocations.Checked = false;
            //pre-analysis
            demultiplex.Checked = false;
            dual.Checked = false;
            f_adapter.Text = String.Empty;
            r_adapter.Text = String.Empty;
        }
        #endregion

        private void settings_Load(object sender, EventArgs e)
        {
            alignBox.SelectedIndex = 0;
            if (global.ssh_status != "connected")
            {
                defaultValues();
            }
            else if (global.ssh_type == "illumina")
            {
                ilmnRadio.Enabled = true;
                ilmnRadio.Checked = true;
                Properties.Settings.Default.chemistry = global.ssh_type;
                ilmnDrop.Text = Properties.Settings.Default.protocol;
            }
            else if (global.ssh_type == "ion torrent")
            {
                ionRadio.Enabled = true;
                ionRadio.Checked = true;
                Properties.Settings.Default.chemistry = global.ssh_type;
                ionDrop.Text = Properties.Settings.Default.protocol;
            }

            alignBox.Text = Properties.Settings.Default.aligner;
            callerBox.Text = Properties.Settings.Default.variant_caller;
            translocations.Checked = Properties.Settings.Default.translocations;
            cnv.Checked = Properties.Settings.Default.cnv;
            indels.Checked = Properties.Settings.Default.indels;
            demultiplex.Checked = Properties.Settings.Default.demultiplex;
            dual.Checked = Properties.Settings.Default.dual_index;
            f_adapter.Text = Properties.Settings.Default.f_adapter;
            r_adapter.Text = Properties.Settings.Default.r_adapter;
        }

        private void ilmnDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            pQueryGrp.Enabled = true;
            aQueryGrp.Enabled = true;
            defaultValues();
            if (Properties.Settings.Default.platform_name.StartsWith("hiseq"))
            {
                demultiplex.Checked = true;
            }
            else
            {
                demultiplex.Checked = false;
            }
            if (ilmnDrop.SelectedItem == "TruSeq")
            {
                dual.Checked = true;
                f_adapter.Text = String.Empty;
                r_adapter.Text = String.Empty;
            }
            else if (ilmnDrop.SelectedItem == "Haloplex")
            {
                dual.Checked = false;
                f_adapter.Text = "AGATCGGAAGAGCACACGTCTGAACTCCAGTCA";
                r_adapter.Text = "AGATCGGAAGAGCGTCGTGTAGGGAAAGAGTGT";
                   
            }
            else if (ilmnDrop.SelectedItem == "RainDance")
            {
                dual.Checked = false;
                f_adapter.Text = "CTG";
                r_adapter.Text = "GAC";
            }
            else
            {
                dual.Checked = false;
                f_adapter.Text = String.Empty;
                r_adapter.Text = String.Empty;
            }
        }

        private void ionDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultValues();
        }
    }
}

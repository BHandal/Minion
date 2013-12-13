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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            this.Text = "Minion - "+Properties.Settings.Default.run +" Settings";
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void default_settings()
        {
            //alignment
            Properties.Settings.Default.aligner = String.Empty;

            Properties.Settings.Default.demultiplex = false;
            Properties.Settings.Default.dual_index = false;
            Properties.Settings.Default.custom_trim = false;
            Properties.Settings.Default.f_adapter = String.Empty;
            Properties.Settings.Default.r_adapter = String.Empty;

            //variant calling
            Properties.Settings.Default.variant_caller = String.Empty;
            Properties.Settings.Default.variant_regions = String.Empty;
            Properties.Settings.Default.validate_variants = String.Empty;
            Properties.Settings.Default.validate_regions = String.Empty;
            Properties.Settings.Default.recalibrate = false;
            Properties.Settings.Default.realign = false;
            Properties.Settings.Default.realign_choice = String.Empty;
            Properties.Settings.Default.mark_duplicates = false;
            Properties.Settings.Default.duplicate_choice = String.Empty;

            //more
            Properties.Settings.Default.rna_seq = false;
            Properties.Settings.Default.fusion = false;
            Properties.Settings.Default.cnv = false;
            Properties.Settings.Default.translocations = false;
            Properties.Settings.Default.indels = false;

            Minion.Properties.Settings.Default.Save();
        }
        private void settings_Load(object sender, EventArgs e)
        {
            if (global.ssh_status != "connected")
            {
                default_settings();
            }
            else platform.Enabled = true;

            //general
            platform.Text = Properties.Settings.Default.platform;
            chemistry.Text = Properties.Settings.Default.chemistry;

            //alignment
            aligner.Text = Properties.Settings.Default.aligner;

            demultiplex.Checked = Properties.Settings.Default.demultiplex;
            dual_index.Checked = Properties.Settings.Default.dual_index;
            custom_trim.Checked = Properties.Settings.Default.custom_trim;
            f_adapter.Text = Properties.Settings.Default.f_adapter;
            r_adapter.Text = Properties.Settings.Default.r_adapter;
            
            //variant calling
            variant_caller.Text = Properties.Settings.Default.variant_caller;
            var_reg_textBox.Text = Properties.Settings.Default.variant_regions;
            val_var_textBox.Text = Properties.Settings.Default.validate_variants;
            val_reg_textBox.Text = Properties.Settings.Default.validate_regions;
            recalibrate.Checked = Properties.Settings.Default.recalibrate;
            realign.Checked = Properties.Settings.Default.realign;
            realign_choice.Text = Properties.Settings.Default.realign_choice;
            duplicates.Checked = Properties.Settings.Default.mark_duplicates;
            duplicate_choice.Text = Properties.Settings.Default.duplicate_choice;

            //more
            rna_seq.Checked = Properties.Settings.Default.rna_seq;
            fusion.Checked = Properties.Settings.Default.fusion;
            cnv.Checked = Properties.Settings.Default.cnv;
            translocations.Checked = Properties.Settings.Default.translocations;
            indels.Checked = Properties.Settings.Default.indels;
        }

        #region Buttons
        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
            foreach (Control c in align_panel.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
            foreach (Control c in variant_panel.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
            f_adapter.Text = String.Empty;
            r_adapter.Text = String.Empty;
            default_settings();
        }
        
        private void applyBtn_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            if (custom_trim.Checked)
            {
                if (String.IsNullOrWhiteSpace(f_adapter.Text))
                {
                    errors.Add("Missing forward adapter");
                }
                if (String.IsNullOrWhiteSpace(r_adapter.Text))
                {
                    errors.Add("Missing reverse adapter");
                }
            }
            if (realign.Checked)
            {
                if (realign_choice.SelectedIndex < 0)
                {
                    errors.Add("Select realignment tool");
                }
            }
            if (duplicates.Checked)
            {
                if (duplicate_choice.SelectedIndex < 0)
                {
                    errors.Add("Select duplicate tool");
                }
            }

            if (errors.Count > 0)
            {
                string err = string.Join("\r\n", errors.ToArray());
                MessageBox.Show("There are errors in your config settings, please see details. \r\n\nDetails:\r\n\n" + err, "Minion - Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errors.Clear();
            }
            else
            {

                //general
                if (platform.SelectedIndex > -1)
                {
                    Properties.Settings.Default.platform = platform.Text.ToString().ToLower();
                }
                if (chemistry.SelectedIndex > -1)
                {
                    Properties.Settings.Default.chemistry = chemistry.Text.ToString().ToLower();
                }

                //alignment
                if (aligner.SelectedIndex > -1)
                {
                    Properties.Settings.Default.aligner = aligner.Text.ToString().ToLower();
                }
                Properties.Settings.Default.demultiplex = demultiplex.Checked;
                Properties.Settings.Default.dual_index = dual_index.Checked;
                Properties.Settings.Default.custom_trim = custom_trim.Checked;
                Properties.Settings.Default.f_adapter = f_adapter.Text;
                Properties.Settings.Default.r_adapter = r_adapter.Text;

                //variant calling
                if (variant_caller.SelectedIndex > -1)
                {
                    Properties.Settings.Default.variant_caller = variant_caller.Text.ToString().ToLower();
                }
                Properties.Settings.Default.variant_regions = var_reg_textBox.Text;
                Properties.Settings.Default.validate_variants = val_var_textBox.Text;
                Properties.Settings.Default.validate_regions = val_reg_textBox.Text;
                Properties.Settings.Default.recalibrate = recalibrate.Checked;
                Properties.Settings.Default.realign = realign.Checked;
                if (realign_choice.SelectedIndex > -1)
                {
                    Properties.Settings.Default.realign_choice = realign_choice.Text.ToString().ToLower();
                }
                Properties.Settings.Default.mark_duplicates = duplicates.Checked;
                if (duplicate_choice.SelectedIndex > -1)
                {
                    Properties.Settings.Default.duplicate_choice = duplicate_choice.Text.ToString().ToLower();
                }

                //more
                Properties.Settings.Default.rna_seq = rna_seq.Checked;
                Properties.Settings.Default.fusion = fusion.Checked;
                Properties.Settings.Default.cnv = cnv.Checked;
                Properties.Settings.Default.translocations = translocations.Checked;
                Properties.Settings.Default.indels = indels.Checked;
                              
                config cf = new config();
                cf.ShowDialog();
                
            }
        }
        private void align_next_Click(object sender, EventArgs e)
        {
            variant_panel.Visible = false;
            more_panel.Visible = false;
            align_panel.Visible = true;

        }
        private void variant_next_Click(object sender, EventArgs e)
        {
            variant_panel.Visible = true;
            more_panel.Visible = false;
            align_panel.Visible = false;
        }
        private void align_next2_Click(object sender, EventArgs e)
        {
            variant_panel.Visible = false;
            more_panel.Visible = false;
            align_panel.Visible = true;
        }
        private void more_next_Click(object sender, EventArgs e)
        {
            more_panel.Visible = true;
            more_panel.BringToFront();
        }
        private void variant_next2_Click(object sender, EventArgs e)
        {
            variant_panel.Visible = true;
            more_panel.Visible = false;
            align_panel.Visible = false;
        }
        private void val_var_browser_Click(object sender, EventArgs e)
        {
            ofd.Filter = "VCF|*.vcf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                val_var_textBox.Text = ofd.FileName;
                global.val_var_file_name = ofd.SafeFileName;
            }

        }
        private void val_reg_browser_Click(object sender, EventArgs e)
        {
            ofd.Filter = "BED|*.bed";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                val_reg_textBox.Text = ofd.FileName;
                global.val_reg_file_name = ofd.SafeFileName;
            }
        }
        private void var_reg_browser_Click(object sender, EventArgs e)
        {
            ofd.Filter = "BED|*.bed";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var_reg_textBox.Text = ofd.FileName;
                global.var_reg_file_name = ofd.SafeFileName;
            }
        }
        #endregion

        #region index changes
        private void chemistry_SelectedIndexChanged(object sender, EventArgs e)
        {
            aligner.Enabled = true;
            variant_caller.Enabled = true;
            if (Properties.Settings.Default.server_name.StartsWith("hiseq")) demultiplex.Checked = true;

            if (chemistry.Text == "TruSeq")
            {
                custom_trim.Checked = false;
                dual_index.Checked = true;
                f_adapter.Text = String.Empty;
                r_adapter.Text = String.Empty;
            }
            else if (chemistry.Text == "Haloplex")
            {
                custom_trim.Checked = true;
                dual_index.Checked = false;
                f_adapter.Text = "AGATCGGAAGAGCACACGTCTGAACTCCAGTCA";
                r_adapter.Text = "AGATCGGAAGAGCGTCGTGTAGGGAAAGAGTGT";

            }
            else if (chemistry.Text == "RainDance")
            {
                custom_trim.Checked = true;
                dual_index.Checked = false;
                f_adapter.Text = "CTG";
                r_adapter.Text = "GAC";
            }
            else
            {
                custom_trim.Checked = false;
                dual_index.Checked = false;
                f_adapter.Text = String.Empty;
                r_adapter.Text = String.Empty;
            }
        }
        private void platform_SelectedIndexChanged(object sender, EventArgs e)
        {
            chemistry.Enabled = true;
            Properties.Settings.Default.platform = platform.Text.ToLower();
            this.chemistry.Items.Clear();
            this.chemistry.SelectedIndex = -1;
            if (Properties.Settings.Default.platform == "illumina")
            {
                this.chemistry.Items.AddRange(new object[] {
                "TruSeq",
                "Haloplex",
                "RainDance",
                "RNA-Seq"});
            }
            else if (Properties.Settings.Default.platform == "ion torrent")
            {
                this.chemistry.Items.AddRange(new object[] {
                "CMS50",
                "CMS400",
                "RNA-Seq"});
            }
        }

        private void aligner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aligner.SelectedIndex > -1)
            {
                foreach (Control c in align_panel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Enabled = true;                     
                    }
                }
            }
            else
            {
                foreach (Control c in align_panel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Enabled = false;
                        ((CheckBox)c).Checked = false;
                    }
                }
            }
        }

        private void variant_caller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variant_caller.SelectedIndex > -1)
            {
                foreach (Control c in variant_panel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Enabled = true;
                    }
                    else if (c is Button)
                    {
                        ((Button)c).Enabled = true;
                    }
                    else if (c is TextBox)
                    {
                        ((TextBox)c).Enabled = true;
                    }
                }
                foreach (Control c in more_panel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Enabled = true;
                    }
                }
            }
            else
            {
                foreach (Control c in variant_panel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Enabled = false;
                        ((CheckBox)c).Checked = false;
                    }
                    else if (c is Button)
                    {
                        ((Button)c).Enabled = false;
                    }
                    else if (c is TextBox)
                    {
                        ((TextBox)c).Enabled = false;
                    }
                }
                foreach (Control c in more_panel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Enabled = false;
                        ((CheckBox)c).Checked = false;
                    }
                }
            }

            align_next2.Enabled = true;
            more_next.Enabled = true;
            less_next.Enabled = true;
            val_reg_browser.Enabled = false;
            val_reg_textBox.Enabled = false;

        }
        #endregion

        #region control changes

        private void custom_trim_CheckedChanged(object sender, EventArgs e)
        {
            if (custom_trim.Checked)
            {
                f_adapter.Enabled = true;
                r_adapter.Enabled = true;
            }
            else
            {
                f_adapter.Enabled = false;
                r_adapter.Enabled = false;
            }
        }

        private void realign_CheckedChanged(object sender, EventArgs e)
        {
            if (realign.Checked)
            {
                realign_choice.Enabled = true;
            }
            else realign_choice.Enabled = false;
        }

        private void duplicates_CheckedChanged(object sender, EventArgs e)
        {
            if (duplicates.Checked)
            {
                duplicate_choice.Enabled = true;
            }
            else duplicate_choice.Enabled = false;
        }

        private void val_var_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(val_reg_textBox.Text))
            {
                val_reg_browser.Enabled = true;
                val_reg_textBox.Enabled = true;
            }
        }
        #endregion
    }
}

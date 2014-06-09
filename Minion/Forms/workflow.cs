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
    public partial class workflow : Form
    {
        public workflow()
        {
            InitializeComponent();

        }
        settings sf = (settings)Application.OpenForms["settings"];
        main mf = (main)Application.OpenForms["main"];

        private void workflow_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.platform))
            {
                workflowTree.Nodes["platform"].Nodes.Add("platform_name", Properties.Settings.Default.platform).NodeFont = new Font(workflowTree.Font, FontStyle.Bold);
                workflowTree.Nodes["platform"].Nodes["platform_name"].Nodes.Add("server_name", Properties.Settings.Default.server_name);
            }
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.chemistry))
            {
                workflowTree.Nodes["chemistry"].Nodes.Add("chemistry_name", Properties.Settings.Default.chemistry).NodeFont = new Font(workflowTree.Font, FontStyle.Bold);
            }
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.run))
            {
                workflowTree.Nodes["run"].Nodes.Add("run_name", Properties.Settings.Default.run).NodeFont = new Font(workflowTree.Font, FontStyle.Bold);
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes.Add("alignment", "Alignment");
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes.Add("aligner", "Aligner");
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes.Add("variant_calling", "Variant Calling");
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes.Add("caller", "Caller");
            }

            #region alignment Nodes
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.aligner))
            {
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes["aligner"].Nodes.Add("aligner_name", Properties.Settings.Default.aligner).NodeFont = new Font(workflowTree.Font, FontStyle.Bold);

                if (Properties.Settings.Default.demultiplex)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes.Add("demultiplex", "Demultiplex");
                }
                if (Properties.Settings.Default.dual_index)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes.Add("dual_index", "Dual indexing");
                }
                if (Properties.Settings.Default.custom_trim)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes.Add("custom_trim", "Trim reads");

                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.f_adapter))
                    {
                        workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes["custom_trim"].Nodes.Add("f_adapter", "F: " + Properties.Settings.Default.f_adapter);
                    }
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.r_adapter))
                    {
                        workflowTree.Nodes["run"].Nodes["run_name"].Nodes["alignment"].Nodes["custom_trim"].Nodes.Add("r_adapter", "R: " + Properties.Settings.Default.r_adapter);
                    }
                }
            }
            #endregion

            #region variant calling
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.variant_caller))
            {
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["caller"].Nodes.Add("caller_name", Properties.Settings.Default.variant_caller).NodeFont = new Font(workflowTree.Font, FontStyle.Bold);

                /*if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.variant_regions) || !String.IsNullOrWhiteSpace(Properties.Settings.Default.validate_variants) || !String.IsNullOrWhiteSpace(Properties.Settings.Default.validate_regions))
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes.Add("files", "Files");
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.variant_regions))
                    {
                        workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["files"].Nodes.Add(global.var_reg_file_name);
                    }
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.validate_regions))
                    {
                        workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["files"].Nodes.Add(global.val_reg_file_name);
                    }
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.validate_variants))
                    {
                        workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["files"].Nodes.Add(global.val_var_file_name);
                    }
                }*/
                if (Properties.Settings.Default.recalibrate)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes.Add("recalibrate", "Recalibrate");
                }
                if (Properties.Settings.Default.realign)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes.Add("realign", "Realign");

                }

            #endregion

                #region misc
                workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes.Add("misc", "Misc.");
                if (Properties.Settings.Default.tophat)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["misc"].Nodes.Add("rna_seq", "RNA-Seq analysis");
                }
                if (Properties.Settings.Default.tophat_fusion)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["misc"].Nodes.Add("fusion", "Fusion analysis");
                }
                if (Properties.Settings.Default.cnvseq)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["misc"].Nodes.Add("cnv", "CNV analysis");
                }
                if (Properties.Settings.Default.breakdancer)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["misc"].Nodes.Add("translocations", "Translocation analysis");
                }
                if (Properties.Settings.Default.pindel)
                {
                    workflowTree.Nodes["run"].Nodes["run_name"].Nodes["variant_calling"].Nodes["misc"].Nodes.Add("indels", "Indel analysis");
                }
            }
            #endregion

            workflowTree.ExpandAll();
        }

        #region Buttons
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mf.status.Text = "Connected";
            mf.status.ForeColor = System.Drawing.Color.DarkGreen;
            mf.mainExecuteBtn.Enabled = false;
            sf.Close();
            Minion.Properties.Settings.Default.Reset();
            Minion.Properties.Settings.Default.Save();
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();                 
        }
        private void yesbtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.type == "main")
            {
                mf.status.Text = "Ready";
                mf.status.ForeColor = System.Drawing.Color.Black;
                mf.mainExecuteBtn.Enabled = true;
            }
            else if (Properties.Settings.Default.type == "custom")
            {
                mf.status.Text = "Ready";
                mf.status.ForeColor = System.Drawing.Color.Black;
                mf.customExecuteBtn.Text = "EXECUTE";
                mf.customExecuteBtn.Enabled = true;
            }
            Properties.Settings.Default.Save();
            sf.Close();
            this.Close();
        }
        #endregion
    }
}

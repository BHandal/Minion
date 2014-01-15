namespace Minion.Forms
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.applyBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.recalibrate = new System.Windows.Forms.CheckBox();
            this.realign = new System.Windows.Forms.CheckBox();
            this.rna_seq = new System.Windows.Forms.CheckBox();
            this.translocations = new System.Windows.Forms.CheckBox();
            this.fusion = new System.Windows.Forms.CheckBox();
            this.indels = new System.Windows.Forms.CheckBox();
            this.cnv = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.ComboBox();
            this.chemistry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aligner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custom_trim = new System.Windows.Forms.CheckBox();
            this.align_panel = new System.Windows.Forms.Panel();
            this.demultiplex = new System.Windows.Forms.CheckBox();
            this.dual_index = new System.Windows.Forms.CheckBox();
            this.variant_next = new System.Windows.Forms.Button();
            this.r_adapter = new Demo.PlaceholderTextBox();
            this.f_adapter = new Demo.PlaceholderTextBox();
            this.variant_panel = new System.Windows.Forms.Panel();
            this.align_next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.variant_caller = new System.Windows.Forms.ComboBox();
            this.align_panel.SuspendLayout();
            this.variant_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.BackColor = System.Drawing.Color.Transparent;
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(327, 293);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(81, 29);
            this.applyBtn.TabIndex = 33;
            this.applyBtn.Text = "OVERVIEW";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBtn.Location = new System.Drawing.Point(12, 293);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(55, 29);
            this.resetBtn.TabIndex = 34;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // recalibrate
            // 
            this.recalibrate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recalibrate.AutoSize = true;
            this.recalibrate.Cursor = System.Windows.Forms.Cursors.Help;
            this.recalibrate.Enabled = false;
            this.recalibrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recalibrate.Location = new System.Drawing.Point(68, 78);
            this.recalibrate.Name = "recalibrate";
            this.recalibrate.Size = new System.Drawing.Size(106, 25);
            this.recalibrate.TabIndex = 37;
            this.recalibrate.Text = "Recalibrate";
            this.toolTip1.SetToolTip(this.recalibrate, "Perform base quality score recalibration on the aligned BAM file. [gatk, false]");
            this.recalibrate.UseVisualStyleBackColor = true;
            // 
            // realign
            // 
            this.realign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.realign.AutoSize = true;
            this.realign.Cursor = System.Windows.Forms.Cursors.Help;
            this.realign.Enabled = false;
            this.realign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realign.Location = new System.Drawing.Point(68, 47);
            this.realign.Name = "realign";
            this.realign.Size = new System.Drawing.Size(81, 25);
            this.realign.TabIndex = 43;
            this.realign.Text = "Realign";
            this.toolTip1.SetToolTip(this.realign, "Perform realignment around indels on the aligned BAM file. [gatk, false]");
            this.realign.UseVisualStyleBackColor = true;
            // 
            // rna_seq
            // 
            this.rna_seq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rna_seq.AutoSize = true;
            this.rna_seq.Cursor = System.Windows.Forms.Cursors.Default;
            this.rna_seq.Enabled = false;
            this.rna_seq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rna_seq.Location = new System.Drawing.Point(207, 47);
            this.rna_seq.Name = "rna_seq";
            this.rna_seq.Size = new System.Drawing.Size(88, 25);
            this.rna_seq.TabIndex = 37;
            this.rna_seq.Text = "TopHat2";
            this.toolTip1.SetToolTip(this.rna_seq, resources.GetString("rna_seq.ToolTip"));
            this.rna_seq.UseVisualStyleBackColor = true;
            // 
            // translocations
            // 
            this.translocations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.translocations.AutoSize = true;
            this.translocations.Cursor = System.Windows.Forms.Cursors.Default;
            this.translocations.Enabled = false;
            this.translocations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translocations.Location = new System.Drawing.Point(68, 139);
            this.translocations.Name = "translocations";
            this.translocations.Size = new System.Drawing.Size(115, 25);
            this.translocations.TabIndex = 47;
            this.translocations.Text = "Breakdancer";
            this.toolTip1.SetToolTip(this.translocations, "An algorithm for high-resolution mapping of genomic structural variation");
            this.translocations.UseVisualStyleBackColor = true;
            // 
            // fusion
            // 
            this.fusion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fusion.AutoSize = true;
            this.fusion.Cursor = System.Windows.Forms.Cursors.Default;
            this.fusion.Enabled = false;
            this.fusion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fusion.Location = new System.Drawing.Point(207, 78);
            this.fusion.Name = "fusion";
            this.fusion.Size = new System.Drawing.Size(131, 25);
            this.fusion.TabIndex = 46;
            this.fusion.Text = "TopHat-Fusion";
            this.toolTip1.SetToolTip(this.fusion, "Align reads across fusion points, which results from the breakage and re-joining " +
        "of two different chromosomes, \r\nor from rearrangements within a chromosome. ");
            this.fusion.UseVisualStyleBackColor = true;
            // 
            // indels
            // 
            this.indels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.indels.AutoSize = true;
            this.indels.Cursor = System.Windows.Forms.Cursors.Default;
            this.indels.Enabled = false;
            this.indels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indels.Location = new System.Drawing.Point(68, 108);
            this.indels.Name = "indels";
            this.indels.Size = new System.Drawing.Size(72, 25);
            this.indels.TabIndex = 72;
            this.indels.Text = "Pindel";
            this.toolTip1.SetToolTip(this.indels, " Detect breakpoints of large deletions, medium sized insertions, inversions, tand" +
        "em duplications and other structural variants \r\nat single-based resolution from " +
        "next-gen sequence data.");
            this.indels.UseVisualStyleBackColor = true;
            // 
            // cnv
            // 
            this.cnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cnv.AutoSize = true;
            this.cnv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cnv.Enabled = false;
            this.cnv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnv.Location = new System.Drawing.Point(207, 109);
            this.cnv.Name = "cnv";
            this.cnv.Size = new System.Drawing.Size(91, 25);
            this.cnv.TabIndex = 73;
            this.cnv.Text = "CNV-seq";
            this.toolTip1.SetToolTip(this.cnv, "Method to detect copy number variation using high-throughput sequencing");
            this.cnv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Platform:";
            // 
            // platform
            // 
            this.platform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.platform.BackColor = System.Drawing.SystemColors.Window;
            this.platform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platform.Enabled = false;
            this.platform.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platform.FormattingEnabled = true;
            this.platform.ItemHeight = 17;
            this.platform.Items.AddRange(new object[] {
            "Illumina",
            "Ion Torrent",
            "Other"});
            this.platform.Location = new System.Drawing.Point(108, 12);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(300, 25);
            this.platform.Sorted = true;
            this.platform.TabIndex = 38;
            this.platform.SelectedIndexChanged += new System.EventHandler(this.platform_SelectedIndexChanged);
            // 
            // chemistry
            // 
            this.chemistry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chemistry.BackColor = System.Drawing.SystemColors.Window;
            this.chemistry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chemistry.Enabled = false;
            this.chemistry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemistry.FormattingEnabled = true;
            this.chemistry.ItemHeight = 17;
            this.chemistry.Location = new System.Drawing.Point(108, 52);
            this.chemistry.Name = "chemistry";
            this.chemistry.Size = new System.Drawing.Size(300, 25);
            this.chemistry.Sorted = true;
            this.chemistry.TabIndex = 40;
            this.chemistry.SelectedIndexChanged += new System.EventHandler(this.chemistry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Chemistry:";
            // 
            // aligner
            // 
            this.aligner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aligner.BackColor = System.Drawing.SystemColors.Window;
            this.aligner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aligner.Enabled = false;
            this.aligner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aligner.FormattingEnabled = true;
            this.aligner.ItemHeight = 17;
            this.aligner.Items.AddRange(new object[] {
            "bowtie",
            "bowtie2",
            "bwa",
            "mosaik",
            "novoalign",
            "NONE"});
            this.aligner.Location = new System.Drawing.Point(96, 12);
            this.aligner.Name = "aligner";
            this.aligner.Size = new System.Drawing.Size(230, 25);
            this.aligner.TabIndex = 42;
            this.aligner.SelectedIndexChanged += new System.EventHandler(this.aligner_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Aligner:";
            // 
            // custom_trim
            // 
            this.custom_trim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.custom_trim.AutoSize = true;
            this.custom_trim.Cursor = System.Windows.Forms.Cursors.Default;
            this.custom_trim.Enabled = false;
            this.custom_trim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_trim.Location = new System.Drawing.Point(192, 63);
            this.custom_trim.Name = "custom_trim";
            this.custom_trim.Size = new System.Drawing.Size(103, 25);
            this.custom_trim.TabIndex = 44;
            this.custom_trim.Text = "Trim reads";
            this.custom_trim.UseVisualStyleBackColor = true;
            this.custom_trim.CheckedChanged += new System.EventHandler(this.custom_trim_CheckedChanged);
            // 
            // align_panel
            // 
            this.align_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.align_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.align_panel.Controls.Add(this.demultiplex);
            this.align_panel.Controls.Add(this.dual_index);
            this.align_panel.Controls.Add(this.variant_next);
            this.align_panel.Controls.Add(this.r_adapter);
            this.align_panel.Controls.Add(this.f_adapter);
            this.align_panel.Controls.Add(this.label3);
            this.align_panel.Controls.Add(this.aligner);
            this.align_panel.Controls.Add(this.custom_trim);
            this.align_panel.Location = new System.Drawing.Point(12, 87);
            this.align_panel.Name = "align_panel";
            this.align_panel.Size = new System.Drawing.Size(396, 200);
            this.align_panel.TabIndex = 57;
            // 
            // demultiplex
            // 
            this.demultiplex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.demultiplex.AutoSize = true;
            this.demultiplex.Cursor = System.Windows.Forms.Cursors.Default;
            this.demultiplex.Enabled = false;
            this.demultiplex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demultiplex.Location = new System.Drawing.Point(68, 63);
            this.demultiplex.Name = "demultiplex";
            this.demultiplex.Size = new System.Drawing.Size(112, 25);
            this.demultiplex.TabIndex = 60;
            this.demultiplex.Text = "Demultiplex";
            this.demultiplex.UseVisualStyleBackColor = true;
            // 
            // dual_index
            // 
            this.dual_index.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dual_index.AutoSize = true;
            this.dual_index.Cursor = System.Windows.Forms.Cursors.Default;
            this.dual_index.Enabled = false;
            this.dual_index.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dual_index.Location = new System.Drawing.Point(68, 93);
            this.dual_index.Name = "dual_index";
            this.dual_index.Size = new System.Drawing.Size(124, 25);
            this.dual_index.TabIndex = 59;
            this.dual_index.Text = "Dual indexing";
            this.dual_index.UseVisualStyleBackColor = true;
            // 
            // variant_next
            // 
            this.variant_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.variant_next.BackColor = System.Drawing.Color.Transparent;
            this.variant_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variant_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variant_next.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variant_next.ForeColor = System.Drawing.SystemColors.WindowText;
            this.variant_next.Location = new System.Drawing.Point(278, 170);
            this.variant_next.Name = "variant_next";
            this.variant_next.Size = new System.Drawing.Size(117, 29);
            this.variant_next.TabIndex = 58;
            this.variant_next.Text = "Variant Calling >>";
            this.variant_next.UseVisualStyleBackColor = false;
            this.variant_next.Click += new System.EventHandler(this.variant_next_Click);
            // 
            // r_adapter
            // 
            this.r_adapter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.r_adapter.Enabled = false;
            this.r_adapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.r_adapter.ForeColor = System.Drawing.Color.LightGray;
            this.r_adapter.Location = new System.Drawing.Point(207, 125);
            this.r_adapter.Name = "r_adapter";
            this.r_adapter.PlaceholderText = "Reverse";
            this.r_adapter.Size = new System.Drawing.Size(156, 25);
            this.r_adapter.TabIndex = 56;
            // 
            // f_adapter
            // 
            this.f_adapter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.f_adapter.Enabled = false;
            this.f_adapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.f_adapter.ForeColor = System.Drawing.Color.LightGray;
            this.f_adapter.Location = new System.Drawing.Point(207, 94);
            this.f_adapter.Name = "f_adapter";
            this.f_adapter.PlaceholderText = "Forward";
            this.f_adapter.Size = new System.Drawing.Size(156, 25);
            this.f_adapter.TabIndex = 55;
            // 
            // variant_panel
            // 
            this.variant_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.variant_panel.Controls.Add(this.cnv);
            this.variant_panel.Controls.Add(this.indels);
            this.variant_panel.Controls.Add(this.rna_seq);
            this.variant_panel.Controls.Add(this.translocations);
            this.variant_panel.Controls.Add(this.fusion);
            this.variant_panel.Controls.Add(this.align_next);
            this.variant_panel.Controls.Add(this.recalibrate);
            this.variant_panel.Controls.Add(this.label4);
            this.variant_panel.Controls.Add(this.variant_caller);
            this.variant_panel.Controls.Add(this.realign);
            this.variant_panel.Location = new System.Drawing.Point(12, 87);
            this.variant_panel.Name = "variant_panel";
            this.variant_panel.Size = new System.Drawing.Size(396, 200);
            this.variant_panel.TabIndex = 61;
            this.variant_panel.Visible = false;
            // 
            // align_next
            // 
            this.align_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.align_next.BackColor = System.Drawing.Color.Transparent;
            this.align_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.align_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.align_next.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.align_next.ForeColor = System.Drawing.SystemColors.WindowText;
            this.align_next.Location = new System.Drawing.Point(-1, 170);
            this.align_next.Name = "align_next";
            this.align_next.Size = new System.Drawing.Size(98, 29);
            this.align_next.TabIndex = 58;
            this.align_next.Text = "<< Alignment";
            this.align_next.UseVisualStyleBackColor = false;
            this.align_next.Click += new System.EventHandler(this.align_next_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Caller:";
            // 
            // variant_caller
            // 
            this.variant_caller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant_caller.BackColor = System.Drawing.SystemColors.Window;
            this.variant_caller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variant_caller.Enabled = false;
            this.variant_caller.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variant_caller.FormattingEnabled = true;
            this.variant_caller.ItemHeight = 17;
            this.variant_caller.Items.AddRange(new object[] {
            "cortex",
            "freebayes",
            "gatk",
            "gatk-haplotype",
            "samtools",
            "varscan",
            "NONE"});
            this.variant_caller.Location = new System.Drawing.Point(96, 12);
            this.variant_caller.Name = "variant_caller";
            this.variant_caller.Size = new System.Drawing.Size(230, 25);
            this.variant_caller.TabIndex = 42;
            this.variant_caller.SelectedIndexChanged += new System.EventHandler(this.variant_caller_SelectedIndexChanged);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(420, 327);
            this.Controls.Add(this.chemistry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.variant_panel);
            this.Controls.Add(this.align_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.align_panel.ResumeLayout(false);
            this.align_panel.PerformLayout();
            this.variant_panel.ResumeLayout(false);
            this.variant_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox platform;
        private System.Windows.Forms.ComboBox chemistry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox aligner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox custom_trim;
        private Demo.PlaceholderTextBox f_adapter;
        private Demo.PlaceholderTextBox r_adapter;
        private System.Windows.Forms.Panel align_panel;
        private System.Windows.Forms.Button variant_next;
        private System.Windows.Forms.CheckBox dual_index;
        private System.Windows.Forms.CheckBox demultiplex;
        private System.Windows.Forms.Panel variant_panel;
        private System.Windows.Forms.Button align_next;
        private System.Windows.Forms.CheckBox recalibrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox variant_caller;
        private System.Windows.Forms.CheckBox realign;
        private System.Windows.Forms.CheckBox cnv;
        private System.Windows.Forms.CheckBox indels;
        private System.Windows.Forms.CheckBox rna_seq;
        private System.Windows.Forms.CheckBox translocations;
        private System.Windows.Forms.CheckBox fusion;

    }
}
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
            this.duplicates = new System.Windows.Forms.CheckBox();
            this.var_reg_browser = new System.Windows.Forms.Button();
            this.val_var_browser = new System.Windows.Forms.Button();
            this.val_reg_browser = new System.Windows.Forms.Button();
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
            this.variant_panel = new System.Windows.Forms.Panel();
            this.more_next = new System.Windows.Forms.Button();
            this.var_reg_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.val_reg_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.val_var_textBox = new System.Windows.Forms.TextBox();
            this.variant_regions = new System.Windows.Forms.Label();
            this.duplicate_choice = new System.Windows.Forms.ComboBox();
            this.realign_choice = new System.Windows.Forms.ComboBox();
            this.align_next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.variant_caller = new System.Windows.Forms.ComboBox();
            this.more_panel = new System.Windows.Forms.Panel();
            this.align_next2 = new System.Windows.Forms.Button();
            this.less_next = new System.Windows.Forms.Button();
            this.r_adapter = new Demo.PlaceholderTextBox();
            this.f_adapter = new Demo.PlaceholderTextBox();
            this.align_panel.SuspendLayout();
            this.variant_panel.SuspendLayout();
            this.more_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.BackColor = System.Drawing.Color.Transparent;
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(327, 387);
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
            this.resetBtn.Location = new System.Drawing.Point(12, 387);
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
            this.recalibrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recalibrate.Location = new System.Drawing.Point(52, 178);
            this.recalibrate.Name = "recalibrate";
            this.recalibrate.Size = new System.Drawing.Size(92, 21);
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
            this.realign.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realign.Location = new System.Drawing.Point(147, 179);
            this.realign.Name = "realign";
            this.realign.Size = new System.Drawing.Size(70, 21);
            this.realign.TabIndex = 43;
            this.realign.Text = "Realign";
            this.toolTip1.SetToolTip(this.realign, "Perform realignment around indels on the aligned BAM file. [gatk, gkno, false]");
            this.realign.UseVisualStyleBackColor = true;
            this.realign.CheckedChanged += new System.EventHandler(this.realign_CheckedChanged);
            // 
            // duplicates
            // 
            this.duplicates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.duplicates.AutoSize = true;
            this.duplicates.Cursor = System.Windows.Forms.Cursors.Help;
            this.duplicates.Enabled = false;
            this.duplicates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duplicates.Location = new System.Drawing.Point(147, 213);
            this.duplicates.Name = "duplicates";
            this.duplicates.Size = new System.Drawing.Size(87, 21);
            this.duplicates.TabIndex = 60;
            this.duplicates.Text = "Duplicates";
            this.toolTip1.SetToolTip(this.duplicates, "Identify and remove variants [picard, biobambam, samtools, false]");
            this.duplicates.UseVisualStyleBackColor = true;
            this.duplicates.CheckedChanged += new System.EventHandler(this.duplicates_CheckedChanged);
            // 
            // var_reg_browser
            // 
            this.var_reg_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.var_reg_browser.BackColor = System.Drawing.Color.Transparent;
            this.var_reg_browser.Cursor = System.Windows.Forms.Cursors.Help;
            this.var_reg_browser.Enabled = false;
            this.var_reg_browser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_reg_browser.Location = new System.Drawing.Point(332, 60);
            this.var_reg_browser.Name = "var_reg_browser";
            this.var_reg_browser.Size = new System.Drawing.Size(59, 22);
            this.var_reg_browser.TabIndex = 58;
            this.var_reg_browser.Text = "Browse";
            this.toolTip1.SetToolTip(this.var_reg_browser, "BED file of regions to call variants in.");
            this.var_reg_browser.UseVisualStyleBackColor = false;
            this.var_reg_browser.Click += new System.EventHandler(this.var_reg_browser_Click);
            // 
            // val_var_browser
            // 
            this.val_var_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.val_var_browser.BackColor = System.Drawing.Color.Transparent;
            this.val_var_browser.Cursor = System.Windows.Forms.Cursors.Help;
            this.val_var_browser.Enabled = false;
            this.val_var_browser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_var_browser.Location = new System.Drawing.Point(332, 101);
            this.val_var_browser.Name = "val_var_browser";
            this.val_var_browser.Size = new System.Drawing.Size(59, 22);
            this.val_var_browser.TabIndex = 64;
            this.val_var_browser.Text = "Browse";
            this.toolTip1.SetToolTip(this.val_var_browser, resources.GetString("val_var_browser.ToolTip"));
            this.val_var_browser.UseVisualStyleBackColor = false;
            this.val_var_browser.Click += new System.EventHandler(this.val_var_browser_Click);
            // 
            // val_reg_browser
            // 
            this.val_reg_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.val_reg_browser.BackColor = System.Drawing.Color.Transparent;
            this.val_reg_browser.Cursor = System.Windows.Forms.Cursors.Help;
            this.val_reg_browser.Enabled = false;
            this.val_reg_browser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_reg_browser.Location = new System.Drawing.Point(332, 144);
            this.val_reg_browser.Name = "val_reg_browser";
            this.val_reg_browser.Size = new System.Drawing.Size(59, 22);
            this.val_reg_browser.TabIndex = 67;
            this.val_reg_browser.Text = "Browse";
            this.toolTip1.SetToolTip(this.val_reg_browser, "A BED file of regions to evaluate in. This defines specific regions covered by th" +
        "e validate VCF file.");
            this.val_reg_browser.UseVisualStyleBackColor = false;
            this.val_reg_browser.Click += new System.EventHandler(this.val_reg_browser_Click);
            // 
            // rna_seq
            // 
            this.rna_seq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rna_seq.AutoSize = true;
            this.rna_seq.Cursor = System.Windows.Forms.Cursors.Default;
            this.rna_seq.Enabled = false;
            this.rna_seq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rna_seq.Location = new System.Drawing.Point(10, 19);
            this.rna_seq.Name = "rna_seq";
            this.rna_seq.Size = new System.Drawing.Size(129, 21);
            this.rna_seq.TabIndex = 37;
            this.rna_seq.Text = "RNA-Seq analysis";
            this.rna_seq.UseVisualStyleBackColor = true;
            // 
            // translocations
            // 
            this.translocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translocations.AutoSize = true;
            this.translocations.Cursor = System.Windows.Forms.Cursors.Default;
            this.translocations.Enabled = false;
            this.translocations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translocations.Location = new System.Drawing.Point(146, 47);
            this.translocations.Name = "translocations";
            this.translocations.Size = new System.Drawing.Size(154, 21);
            this.translocations.TabIndex = 47;
            this.translocations.Text = "Translocation analysis";
            this.translocations.UseVisualStyleBackColor = true;
            // 
            // fusion
            // 
            this.fusion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fusion.AutoSize = true;
            this.fusion.Cursor = System.Windows.Forms.Cursors.Default;
            this.fusion.Enabled = false;
            this.fusion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fusion.Location = new System.Drawing.Point(10, 47);
            this.fusion.Name = "fusion";
            this.fusion.Size = new System.Drawing.Size(113, 21);
            this.fusion.TabIndex = 46;
            this.fusion.Text = "Fusion analysis";
            this.fusion.UseVisualStyleBackColor = true;
            // 
            // indels
            // 
            this.indels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.indels.AutoSize = true;
            this.indels.Cursor = System.Windows.Forms.Cursors.Default;
            this.indels.Enabled = false;
            this.indels.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indels.Location = new System.Drawing.Point(278, 20);
            this.indels.Name = "indels";
            this.indels.Size = new System.Drawing.Size(104, 21);
            this.indels.TabIndex = 72;
            this.indels.Text = "Indel analysis";
            this.indels.UseVisualStyleBackColor = true;
            // 
            // cnv
            // 
            this.cnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnv.AutoSize = true;
            this.cnv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cnv.Enabled = false;
            this.cnv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnv.Location = new System.Drawing.Point(146, 19);
            this.cnv.Name = "cnv";
            this.cnv.Size = new System.Drawing.Size(102, 21);
            this.cnv.TabIndex = 73;
            this.cnv.Text = "CNV analysis";
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
            this.custom_trim.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_trim.Location = new System.Drawing.Point(52, 144);
            this.custom_trim.Name = "custom_trim";
            this.custom_trim.Size = new System.Drawing.Size(160, 41);
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
            this.align_panel.Size = new System.Drawing.Size(396, 285);
            this.align_panel.TabIndex = 57;
            // 
            // demultiplex
            // 
            this.demultiplex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.demultiplex.AutoSize = true;
            this.demultiplex.Cursor = System.Windows.Forms.Cursors.Default;
            this.demultiplex.Enabled = false;
            this.demultiplex.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demultiplex.Location = new System.Drawing.Point(52, 64);
            this.demultiplex.Name = "demultiplex";
            this.demultiplex.Size = new System.Drawing.Size(179, 41);
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
            this.dual_index.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dual_index.Location = new System.Drawing.Point(52, 107);
            this.dual_index.Name = "dual_index";
            this.dual_index.Size = new System.Drawing.Size(200, 41);
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
            this.variant_next.Location = new System.Drawing.Point(278, 255);
            this.variant_next.Name = "variant_next";
            this.variant_next.Size = new System.Drawing.Size(117, 29);
            this.variant_next.TabIndex = 58;
            this.variant_next.Text = "Variant Calling >>";
            this.variant_next.UseVisualStyleBackColor = false;
            this.variant_next.Click += new System.EventHandler(this.variant_next_Click);
            // 
            // variant_panel
            // 
            this.variant_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.variant_panel.Controls.Add(this.more_next);
            this.variant_panel.Controls.Add(this.var_reg_textBox);
            this.variant_panel.Controls.Add(this.label6);
            this.variant_panel.Controls.Add(this.val_reg_browser);
            this.variant_panel.Controls.Add(this.val_reg_textBox);
            this.variant_panel.Controls.Add(this.label5);
            this.variant_panel.Controls.Add(this.val_var_browser);
            this.variant_panel.Controls.Add(this.val_var_textBox);
            this.variant_panel.Controls.Add(this.variant_regions);
            this.variant_panel.Controls.Add(this.var_reg_browser);
            this.variant_panel.Controls.Add(this.duplicate_choice);
            this.variant_panel.Controls.Add(this.duplicates);
            this.variant_panel.Controls.Add(this.realign_choice);
            this.variant_panel.Controls.Add(this.align_next);
            this.variant_panel.Controls.Add(this.recalibrate);
            this.variant_panel.Controls.Add(this.label4);
            this.variant_panel.Controls.Add(this.variant_caller);
            this.variant_panel.Controls.Add(this.realign);
            this.variant_panel.Location = new System.Drawing.Point(12, 87);
            this.variant_panel.Name = "variant_panel";
            this.variant_panel.Size = new System.Drawing.Size(396, 285);
            this.variant_panel.TabIndex = 61;
            this.variant_panel.Visible = false;
            // 
            // more_next
            // 
            this.more_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.more_next.BackColor = System.Drawing.Color.Transparent;
            this.more_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more_next.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more_next.ForeColor = System.Drawing.SystemColors.WindowText;
            this.more_next.Location = new System.Drawing.Point(317, 255);
            this.more_next.Name = "more_next";
            this.more_next.Size = new System.Drawing.Size(78, 29);
            this.more_next.TabIndex = 70;
            this.more_next.Text = "More >>";
            this.more_next.UseVisualStyleBackColor = false;
            this.more_next.Click += new System.EventHandler(this.more_next_Click);
            // 
            // var_reg_textBox
            // 
            this.var_reg_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_reg_textBox.Enabled = false;
            this.var_reg_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_reg_textBox.Location = new System.Drawing.Point(10, 60);
            this.var_reg_textBox.Name = "var_reg_textBox";
            this.var_reg_textBox.Size = new System.Drawing.Size(316, 22);
            this.var_reg_textBox.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Validate regions: (bed)";
            // 
            // val_reg_textBox
            // 
            this.val_reg_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.val_reg_textBox.Enabled = false;
            this.val_reg_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_reg_textBox.Location = new System.Drawing.Point(10, 144);
            this.val_reg_textBox.Name = "val_reg_textBox";
            this.val_reg_textBox.Size = new System.Drawing.Size(316, 22);
            this.val_reg_textBox.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Validate variants: (vcf)";
            // 
            // val_var_textBox
            // 
            this.val_var_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.val_var_textBox.Enabled = false;
            this.val_var_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_var_textBox.Location = new System.Drawing.Point(10, 101);
            this.val_var_textBox.Name = "val_var_textBox";
            this.val_var_textBox.Size = new System.Drawing.Size(316, 22);
            this.val_var_textBox.TabIndex = 65;
            this.val_var_textBox.TextChanged += new System.EventHandler(this.val_var_textBox_TextChanged);
            // 
            // variant_regions
            // 
            this.variant_regions.AutoSize = true;
            this.variant_regions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variant_regions.Location = new System.Drawing.Point(7, 40);
            this.variant_regions.Name = "variant_regions";
            this.variant_regions.Size = new System.Drawing.Size(135, 17);
            this.variant_regions.TabIndex = 63;
            this.variant_regions.Text = "Variant regions: (bed)";
            // 
            // duplicate_choice
            // 
            this.duplicate_choice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.duplicate_choice.BackColor = System.Drawing.SystemColors.Window;
            this.duplicate_choice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duplicate_choice.Enabled = false;
            this.duplicate_choice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duplicate_choice.FormattingEnabled = true;
            this.duplicate_choice.ItemHeight = 17;
            this.duplicate_choice.Items.AddRange(new object[] {
            "biobambam",
            "picard",
            "samtools"});
            this.duplicate_choice.Location = new System.Drawing.Point(237, 211);
            this.duplicate_choice.Name = "duplicate_choice";
            this.duplicate_choice.Size = new System.Drawing.Size(89, 25);
            this.duplicate_choice.Sorted = true;
            this.duplicate_choice.TabIndex = 61;
            // 
            // realign_choice
            // 
            this.realign_choice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.realign_choice.BackColor = System.Drawing.SystemColors.Window;
            this.realign_choice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.realign_choice.Enabled = false;
            this.realign_choice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realign_choice.FormattingEnabled = true;
            this.realign_choice.ItemHeight = 17;
            this.realign_choice.Items.AddRange(new object[] {
            "gatk",
            "gkno"});
            this.realign_choice.Location = new System.Drawing.Point(238, 177);
            this.realign_choice.Name = "realign_choice";
            this.realign_choice.Size = new System.Drawing.Size(88, 25);
            this.realign_choice.Sorted = true;
            this.realign_choice.TabIndex = 59;
            // 
            // align_next
            // 
            this.align_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.align_next.BackColor = System.Drawing.Color.Transparent;
            this.align_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.align_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.align_next.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.align_next.ForeColor = System.Drawing.SystemColors.WindowText;
            this.align_next.Location = new System.Drawing.Point(-1, 255);
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
            // more_panel
            // 
            this.more_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.more_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.more_panel.Controls.Add(this.cnv);
            this.more_panel.Controls.Add(this.indels);
            this.more_panel.Controls.Add(this.align_next2);
            this.more_panel.Controls.Add(this.less_next);
            this.more_panel.Controls.Add(this.rna_seq);
            this.more_panel.Controls.Add(this.translocations);
            this.more_panel.Controls.Add(this.fusion);
            this.more_panel.Location = new System.Drawing.Point(12, 260);
            this.more_panel.Name = "more_panel";
            this.more_panel.Size = new System.Drawing.Size(396, 112);
            this.more_panel.TabIndex = 71;
            this.more_panel.Visible = false;
            // 
            // align_next2
            // 
            this.align_next2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.align_next2.BackColor = System.Drawing.Color.Transparent;
            this.align_next2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.align_next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.align_next2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.align_next2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.align_next2.Location = new System.Drawing.Point(297, 82);
            this.align_next2.Name = "align_next2";
            this.align_next2.Size = new System.Drawing.Size(98, 29);
            this.align_next2.TabIndex = 71;
            this.align_next2.Text = "Alignment >>";
            this.align_next2.UseVisualStyleBackColor = false;
            this.align_next2.Click += new System.EventHandler(this.align_next2_Click);
            // 
            // less_next
            // 
            this.less_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.less_next.BackColor = System.Drawing.Color.Transparent;
            this.less_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.less_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.less_next.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less_next.ForeColor = System.Drawing.SystemColors.WindowText;
            this.less_next.Location = new System.Drawing.Point(-1, 82);
            this.less_next.Name = "less_next";
            this.less_next.Size = new System.Drawing.Size(66, 29);
            this.less_next.TabIndex = 58;
            this.less_next.Text = "<< Less";
            this.less_next.UseVisualStyleBackColor = false;
            this.less_next.Click += new System.EventHandler(this.variant_next2_Click);
            // 
            // r_adapter
            // 
            this.r_adapter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.r_adapter.Enabled = false;
            this.r_adapter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.r_adapter.ForeColor = System.Drawing.Color.LightGray;
            this.r_adapter.Location = new System.Drawing.Point(96, 219);
            this.r_adapter.Name = "r_adapter";
            this.r_adapter.PlaceholderText = "Reverse";
            this.r_adapter.Size = new System.Drawing.Size(156, 22);
            this.r_adapter.TabIndex = 56;
            // 
            // f_adapter
            // 
            this.f_adapter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.f_adapter.Enabled = false;
            this.f_adapter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.f_adapter.ForeColor = System.Drawing.Color.LightGray;
            this.f_adapter.Location = new System.Drawing.Point(96, 191);
            this.f_adapter.Name = "f_adapter";
            this.f_adapter.PlaceholderText = "Forward";
            this.f_adapter.Size = new System.Drawing.Size(156, 22);
            this.f_adapter.TabIndex = 55;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(420, 421);
            this.Controls.Add(this.chemistry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.align_panel);
            this.Controls.Add(this.variant_panel);
            this.Controls.Add(this.more_panel);
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
            this.more_panel.ResumeLayout(false);
            this.more_panel.PerformLayout();
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
        private System.Windows.Forms.ComboBox duplicate_choice;
        private System.Windows.Forms.CheckBox duplicates;
        private System.Windows.Forms.ComboBox realign_choice;
        private System.Windows.Forms.Button align_next;
        private System.Windows.Forms.CheckBox recalibrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox variant_caller;
        private System.Windows.Forms.CheckBox realign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button val_reg_browser;
        private System.Windows.Forms.TextBox val_reg_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button val_var_browser;
        private System.Windows.Forms.TextBox val_var_textBox;
        private System.Windows.Forms.Label variant_regions;
        private System.Windows.Forms.Button var_reg_browser;
        private System.Windows.Forms.TextBox var_reg_textBox;
        private System.Windows.Forms.Button more_next;
        private System.Windows.Forms.Panel more_panel;
        private System.Windows.Forms.CheckBox cnv;
        private System.Windows.Forms.CheckBox indels;
        private System.Windows.Forms.Button align_next2;
        private System.Windows.Forms.Button less_next;
        private System.Windows.Forms.CheckBox rna_seq;
        private System.Windows.Forms.CheckBox translocations;
        private System.Windows.Forms.CheckBox fusion;

    }
}
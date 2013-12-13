namespace SEQuipt.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.chemGrp = new System.Windows.Forms.GroupBox();
            this.ionDrop = new System.Windows.Forms.ComboBox();
            this.ilmnDrop = new System.Windows.Forms.ComboBox();
            this.ionRadio = new System.Windows.Forms.RadioButton();
            this.ilmnRadio = new System.Windows.Forms.RadioButton();
            this.applyBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pQueryGrp = new System.Windows.Forms.GroupBox();
            this.dual = new System.Windows.Forms.CheckBox();
            this.demultiplex = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f_adapter = new System.Windows.Forms.TextBox();
            this.r_adapter = new System.Windows.Forms.TextBox();
            this.aQueryGrp = new System.Windows.Forms.GroupBox();
            this.translocations = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.indels = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cnv = new System.Windows.Forms.CheckBox();
            this.callerBox = new System.Windows.Forms.ComboBox();
            this.alignBox = new System.Windows.Forms.ComboBox();
            this.chemGrp.SuspendLayout();
            this.pQueryGrp.SuspendLayout();
            this.aQueryGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // chemGrp
            // 
            this.chemGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chemGrp.Controls.Add(this.ionDrop);
            this.chemGrp.Controls.Add(this.ilmnDrop);
            this.chemGrp.Controls.Add(this.ionRadio);
            this.chemGrp.Controls.Add(this.ilmnRadio);
            this.chemGrp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemGrp.Location = new System.Drawing.Point(12, 12);
            this.chemGrp.Name = "chemGrp";
            this.chemGrp.Size = new System.Drawing.Size(510, 114);
            this.chemGrp.TabIndex = 8;
            this.chemGrp.TabStop = false;
            this.chemGrp.Text = "Chemistry";
            // 
            // ionDrop
            // 
            this.ionDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ionDrop.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ionDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ionDrop.Enabled = false;
            this.ionDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ionDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionDrop.FormattingEnabled = true;
            this.ionDrop.ItemHeight = 21;
            this.ionDrop.Items.AddRange(new object[] {
            "CMS 400",
            "CMS 50",
            "RNASeq"});
            this.ionDrop.Location = new System.Drawing.Point(184, 68);
            this.ionDrop.Name = "ionDrop";
            this.ionDrop.Size = new System.Drawing.Size(262, 29);
            this.ionDrop.Sorted = true;
            this.ionDrop.TabIndex = 30;
            this.ionDrop.SelectedIndexChanged += new System.EventHandler(this.ionDrop_SelectedIndexChanged);
            // 
            // ilmnDrop
            // 
            this.ilmnDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ilmnDrop.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ilmnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilmnDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilmnDrop.Enabled = false;
            this.ilmnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ilmnDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilmnDrop.FormattingEnabled = true;
            this.ilmnDrop.ItemHeight = 21;
            this.ilmnDrop.Items.AddRange(new object[] {
            "Epicenter",
            "Haloplex",
            "RainDance",
            "TruSeq"});
            this.ilmnDrop.Location = new System.Drawing.Point(184, 24);
            this.ilmnDrop.Name = "ilmnDrop";
            this.ilmnDrop.Size = new System.Drawing.Size(262, 29);
            this.ilmnDrop.Sorted = true;
            this.ilmnDrop.TabIndex = 29;
            this.ilmnDrop.SelectedIndexChanged += new System.EventHandler(this.ilmnDrop_SelectedIndexChanged);
            // 
            // ionRadio
            // 
            this.ionRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ionRadio.AutoSize = true;
            this.ionRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ionRadio.Enabled = false;
            this.ionRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionRadio.Location = new System.Drawing.Point(43, 68);
            this.ionRadio.Name = "ionRadio";
            this.ionRadio.Size = new System.Drawing.Size(105, 25);
            this.ionRadio.TabIndex = 5;
            this.ionRadio.Text = "Ion Torrent";
            this.ionRadio.UseVisualStyleBackColor = true;
            this.ionRadio.CheckedChanged += new System.EventHandler(this.ionRadio_CheckedChanged);
            // 
            // ilmnRadio
            // 
            this.ilmnRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ilmnRadio.AutoSize = true;
            this.ilmnRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilmnRadio.Enabled = false;
            this.ilmnRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilmnRadio.Location = new System.Drawing.Point(43, 24);
            this.ilmnRadio.Name = "ilmnRadio";
            this.ilmnRadio.Size = new System.Drawing.Size(84, 25);
            this.ilmnRadio.TabIndex = 4;
            this.ilmnRadio.Text = "Illumina";
            this.ilmnRadio.UseVisualStyleBackColor = true;
            this.ilmnRadio.CheckedChanged += new System.EventHandler(this.ilmnRadio_CheckedChanged);
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.BackColor = System.Drawing.Color.Transparent;
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(441, 356);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(81, 29);
            this.applyBtn.TabIndex = 33;
            this.applyBtn.Text = "APPLY";
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
            this.resetBtn.Location = new System.Drawing.Point(12, 356);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(55, 29);
            this.resetBtn.TabIndex = 34;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pQueryGrp
            // 
            this.pQueryGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pQueryGrp.Controls.Add(this.dual);
            this.pQueryGrp.Controls.Add(this.demultiplex);
            this.pQueryGrp.Controls.Add(this.label3);
            this.pQueryGrp.Controls.Add(this.label2);
            this.pQueryGrp.Controls.Add(this.label1);
            this.pQueryGrp.Controls.Add(this.f_adapter);
            this.pQueryGrp.Controls.Add(this.r_adapter);
            this.pQueryGrp.Enabled = false;
            this.pQueryGrp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pQueryGrp.Location = new System.Drawing.Point(12, 132);
            this.pQueryGrp.Name = "pQueryGrp";
            this.pQueryGrp.Size = new System.Drawing.Size(510, 101);
            this.pQueryGrp.TabIndex = 31;
            this.pQueryGrp.TabStop = false;
            this.pQueryGrp.Text = "Pre-Analysis Query";
            // 
            // dual
            // 
            this.dual.AutoSize = true;
            this.dual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dual.Location = new System.Drawing.Point(41, 64);
            this.dual.Name = "dual";
            this.dual.Size = new System.Drawing.Size(103, 21);
            this.dual.TabIndex = 5;
            this.dual.Text = "Dual Indexed";
            this.dual.UseVisualStyleBackColor = true;
            // 
            // demultiplex
            // 
            this.demultiplex.AutoSize = true;
            this.demultiplex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demultiplex.Location = new System.Drawing.Point(41, 37);
            this.demultiplex.Name = "demultiplex";
            this.demultiplex.Size = new System.Drawing.Size(141, 21);
            this.demultiplex.TabIndex = 3;
            this.demultiplex.Text = "Demultiplex (HiSeq)";
            this.demultiplex.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adapters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reverse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forward";
            // 
            // f_adapter
            // 
            this.f_adapter.Location = new System.Drawing.Point(284, 33);
            this.f_adapter.Name = "f_adapter";
            this.f_adapter.Size = new System.Drawing.Size(196, 25);
            this.f_adapter.TabIndex = 1;
            // 
            // r_adapter
            // 
            this.r_adapter.Location = new System.Drawing.Point(284, 64);
            this.r_adapter.Name = "r_adapter";
            this.r_adapter.Size = new System.Drawing.Size(196, 25);
            this.r_adapter.TabIndex = 0;
            // 
            // aQueryGrp
            // 
            this.aQueryGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aQueryGrp.Controls.Add(this.translocations);
            this.aQueryGrp.Controls.Add(this.label5);
            this.aQueryGrp.Controls.Add(this.indels);
            this.aQueryGrp.Controls.Add(this.label4);
            this.aQueryGrp.Controls.Add(this.cnv);
            this.aQueryGrp.Controls.Add(this.callerBox);
            this.aQueryGrp.Controls.Add(this.alignBox);
            this.aQueryGrp.Enabled = false;
            this.aQueryGrp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aQueryGrp.Location = new System.Drawing.Point(12, 239);
            this.aQueryGrp.Name = "aQueryGrp";
            this.aQueryGrp.Size = new System.Drawing.Size(510, 106);
            this.aQueryGrp.TabIndex = 32;
            this.aQueryGrp.TabStop = false;
            this.aQueryGrp.Text = "Analysis Query";
            // 
            // translocations
            // 
            this.translocations.AutoSize = true;
            this.translocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translocations.Location = new System.Drawing.Point(369, 75);
            this.translocations.Name = "translocations";
            this.translocations.Size = new System.Drawing.Size(111, 21);
            this.translocations.TabIndex = 2;
            this.translocations.Text = "Translocations";
            this.translocations.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Variant Caller";
            // 
            // indels
            // 
            this.indels.AutoSize = true;
            this.indels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indels.Location = new System.Drawing.Point(369, 51);
            this.indels.Name = "indels";
            this.indels.Size = new System.Drawing.Size(61, 21);
            this.indels.TabIndex = 1;
            this.indels.Text = "Indels";
            this.indels.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Aligner";
            // 
            // cnv
            // 
            this.cnv.AutoSize = true;
            this.cnv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cnv.Location = new System.Drawing.Point(369, 24);
            this.cnv.Name = "cnv";
            this.cnv.Size = new System.Drawing.Size(53, 21);
            this.cnv.TabIndex = 0;
            this.cnv.Text = "CNV";
            this.cnv.UseVisualStyleBackColor = true;
            // 
            // callerBox
            // 
            this.callerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.callerBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.callerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.callerBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.callerBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callerBox.FormattingEnabled = true;
            this.callerBox.ItemHeight = 21;
            this.callerBox.Items.AddRange(new object[] {
            "gatk",
            "PolyBayes",
            "samtools"});
            this.callerBox.Location = new System.Drawing.Point(130, 67);
            this.callerBox.Name = "callerBox";
            this.callerBox.Size = new System.Drawing.Size(225, 29);
            this.callerBox.Sorted = true;
            this.callerBox.TabIndex = 32;
            // 
            // alignBox
            // 
            this.alignBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alignBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.alignBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alignBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alignBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alignBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignBox.FormattingEnabled = true;
            this.alignBox.ItemHeight = 21;
            this.alignBox.Items.AddRange(new object[] {
            "bwa",
            "gatk",
            "tmap"});
            this.alignBox.Location = new System.Drawing.Point(130, 24);
            this.alignBox.Name = "alignBox";
            this.alignBox.Size = new System.Drawing.Size(225, 29);
            this.alignBox.Sorted = true;
            this.alignBox.TabIndex = 31;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 390);
            this.Controls.Add(this.pQueryGrp);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.chemGrp);
            this.Controls.Add(this.aQueryGrp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEQuipt - Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.chemGrp.ResumeLayout(false);
            this.chemGrp.PerformLayout();
            this.pQueryGrp.ResumeLayout(false);
            this.pQueryGrp.PerformLayout();
            this.aQueryGrp.ResumeLayout(false);
            this.aQueryGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chemGrp;
        private System.Windows.Forms.RadioButton ionRadio;
        private System.Windows.Forms.RadioButton ilmnRadio;
        private System.Windows.Forms.ComboBox ionDrop;
        private System.Windows.Forms.ComboBox ilmnDrop;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox pQueryGrp;
        private System.Windows.Forms.CheckBox dual;
        private System.Windows.Forms.CheckBox demultiplex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f_adapter;
        private System.Windows.Forms.TextBox r_adapter;
        private System.Windows.Forms.GroupBox aQueryGrp;
        private System.Windows.Forms.CheckBox translocations;
        private System.Windows.Forms.CheckBox indels;
        private System.Windows.Forms.CheckBox cnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox callerBox;
        private System.Windows.Forms.ComboBox alignBox;

    }
}
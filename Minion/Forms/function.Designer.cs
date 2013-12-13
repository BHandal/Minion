namespace Minion.Forms
{
    partial class function
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(function));
            this.aBtn = new System.Windows.Forms.Button();
            this.vBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aBtn
            // 
            this.aBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aBtn.BackColor = System.Drawing.SystemColors.Window;
            this.aBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.aBtn.FlatAppearance.BorderSize = 2;
            this.aBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuBar;
            this.aBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.aBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.aBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.aBtn.Image = ((System.Drawing.Image)(resources.GetObject("aBtn.Image")));
            this.aBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aBtn.Location = new System.Drawing.Point(12, 12);
            this.aBtn.Name = "aBtn";
            this.aBtn.Size = new System.Drawing.Size(129, 103);
            this.aBtn.TabIndex = 2;
            this.aBtn.TabStop = false;
            this.aBtn.Text = "ANALYZE";
            this.aBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.aBtn, "Analyze");
            this.aBtn.UseVisualStyleBackColor = false;
            this.aBtn.Click += new System.EventHandler(this.aBtn_Click);
            // 
            // vBtn
            // 
            this.vBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vBtn.BackColor = System.Drawing.Color.Transparent;
            this.vBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.vBtn.FlatAppearance.BorderSize = 2;
            this.vBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuBar;
            this.vBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.vBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.vBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.vBtn.Image = ((System.Drawing.Image)(resources.GetObject("vBtn.Image")));
            this.vBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vBtn.Location = new System.Drawing.Point(184, 12);
            this.vBtn.Name = "vBtn";
            this.vBtn.Size = new System.Drawing.Size(129, 103);
            this.vBtn.TabIndex = 3;
            this.vBtn.TabStop = false;
            this.vBtn.Text = "VISUALIZE";
            this.vBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.vBtn, "Visualize");
            this.vBtn.UseVisualStyleBackColor = false;
            this.vBtn.Click += new System.EventHandler(this.vBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(147, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "OR";
            // 
            // function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(325, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vBtn);
            this.Controls.Add(this.aBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "function";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minion - Function Selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.function_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aBtn;
        private System.Windows.Forms.Button vBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}
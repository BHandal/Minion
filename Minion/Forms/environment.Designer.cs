namespace Minion.Forms
{
    partial class environment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(environment));
            this.history = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.history)).BeginInit();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.AllowUserToAddRows = false;
            this.history.AllowUserToDeleteRows = false;
            this.history.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.history.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.history.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.history.BackgroundColor = System.Drawing.SystemColors.Window;
            this.history.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.MultiSelect = false;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.history.Size = new System.Drawing.Size(284, 262);
            this.history.TabIndex = 26;
            this.history.TabStop = false;
            // 
            // environment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.history);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "environment";
            this.Text = "Minion - Environment Selection";
            ((System.ComponentModel.ISupportInitialize)(this.history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView history;
    }
}
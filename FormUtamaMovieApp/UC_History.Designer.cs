namespace FormUtamaMovieApp
{
    partial class UC_History
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteHistory = new System.Windows.Forms.Button();
            this.labelDaftarHistory = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteHistory
            // 
            this.btnDeleteHistory.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHistory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteHistory.Location = new System.Drawing.Point(332, 19);
            this.btnDeleteHistory.Name = "btnDeleteHistory";
            this.btnDeleteHistory.Size = new System.Drawing.Size(136, 35);
            this.btnDeleteHistory.TabIndex = 8;
            this.btnDeleteHistory.Text = "delete History";
            this.btnDeleteHistory.UseVisualStyleBackColor = false;
            // 
            // labelDaftarHistory
            // 
            this.labelDaftarHistory.AutoSize = true;
            this.labelDaftarHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarHistory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDaftarHistory.Location = new System.Drawing.Point(18, 18);
            this.labelDaftarHistory.Name = "labelDaftarHistory";
            this.labelDaftarHistory.Size = new System.Drawing.Size(177, 32);
            this.labelDaftarHistory.TabIndex = 7;
            this.labelDaftarHistory.Text = "Daftar History";
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(27, 66);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 28;
            this.dgvHistory.Size = new System.Drawing.Size(446, 174);
            this.dgvHistory.TabIndex = 9;
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnDeleteHistory);
            this.Controls.Add(this.labelDaftarHistory);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(497, 262);
            this.Load += new System.EventHandler(this.UC_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteHistory;
        private System.Windows.Forms.Label labelDaftarHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}

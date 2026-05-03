namespace FormUtamaMovieApp
{
    partial class UC_Watchlist
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
            this.labelDaftarWatchlist = new System.Windows.Forms.Label();
            this.flpWatchlist = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelDaftarWatchlist
            // 
            this.labelDaftarWatchlist.AutoSize = true;
            this.labelDaftarWatchlist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarWatchlist.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDaftarWatchlist.Location = new System.Drawing.Point(23, 15);
            this.labelDaftarWatchlist.Name = "labelDaftarWatchlist";
            this.labelDaftarWatchlist.Size = new System.Drawing.Size(198, 32);
            this.labelDaftarWatchlist.TabIndex = 4;
            this.labelDaftarWatchlist.Text = "Daftar Watchlist";
            // 
            // flpWatchlist
            // 
            this.flpWatchlist.AutoScroll = true;
            this.flpWatchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpWatchlist.Location = new System.Drawing.Point(20, 50);
            this.flpWatchlist.Name = "flpWatchlist";
            this.flpWatchlist.Size = new System.Drawing.Size(552, 311);
            this.flpWatchlist.TabIndex = 3;
            // 
            // UC_Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.labelDaftarWatchlist);
            this.Controls.Add(this.flpWatchlist);
            this.Name = "UC_Watchlist";
            this.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.Size = new System.Drawing.Size(592, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDaftarWatchlist;
        private System.Windows.Forms.FlowLayoutPanel flpWatchlist;
    }
}

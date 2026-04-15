namespace FormUtamaMovieApp
{
    partial class UC_KatalogMovie
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
            this.flpKatalogMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDaftarMovie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpKatalogMovie
            // 
            this.flpKatalogMovie.AutoScroll = true;
            this.flpKatalogMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKatalogMovie.Location = new System.Drawing.Point(20, 0);
            this.flpKatalogMovie.Name = "flpKatalogMovie";
            this.flpKatalogMovie.Size = new System.Drawing.Size(457, 262);
            this.flpKatalogMovie.TabIndex = 0;
            // 
            // labelDaftarMovie
            // 
            this.labelDaftarMovie.AutoSize = true;
            this.labelDaftarMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarMovie.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDaftarMovie.Location = new System.Drawing.Point(39, 13);
            this.labelDaftarMovie.Name = "labelDaftarMovie";
            this.labelDaftarMovie.Size = new System.Drawing.Size(164, 32);
            this.labelDaftarMovie.TabIndex = 1;
            this.labelDaftarMovie.Text = "Daftar Movie";
            // 
            // UC_KatalogMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.labelDaftarMovie);
            this.Controls.Add(this.flpKatalogMovie);
            this.Name = "UC_KatalogMovie";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(497, 262);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKatalogMovie;
        private System.Windows.Forms.Label labelDaftarMovie;
    }
}

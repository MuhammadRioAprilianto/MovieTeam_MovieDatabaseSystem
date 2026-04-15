namespace FormUtamaMovieApp
{
    partial class UC_ManageMovie
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
            this.flpAdminKatalog = new System.Windows.Forms.FlowLayoutPanel();
            this.labelManageMovie = new System.Windows.Forms.Label();
            this.flpKatalogMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTambahMovie = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCariMovie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flpAdminKatalog
            // 
            this.flpAdminKatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdminKatalog.Location = new System.Drawing.Point(10, 100);
            this.flpAdminKatalog.Name = "flpAdminKatalog";
            this.flpAdminKatalog.Padding = new System.Windows.Forms.Padding(10);
            this.flpAdminKatalog.Size = new System.Drawing.Size(572, 271);
            this.flpAdminKatalog.TabIndex = 0;
            // 
            // labelManageMovie
            // 
            this.labelManageMovie.AutoSize = true;
            this.labelManageMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageMovie.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelManageMovie.Location = new System.Drawing.Point(13, 11);
            this.labelManageMovie.Name = "labelManageMovie";
            this.labelManageMovie.Size = new System.Drawing.Size(184, 32);
            this.labelManageMovie.TabIndex = 3;
            this.labelManageMovie.Text = "Manage Movie";
            // 
            // flpKatalogMovie
            // 
            this.flpKatalogMovie.AutoScroll = true;
            this.flpKatalogMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKatalogMovie.Location = new System.Drawing.Point(10, 100);
            this.flpKatalogMovie.Name = "flpKatalogMovie";
            this.flpKatalogMovie.Size = new System.Drawing.Size(572, 271);
            this.flpKatalogMovie.TabIndex = 2;
            // 
            // btnTambahMovie
            // 
            this.btnTambahMovie.BackColor = System.Drawing.Color.Yellow;
            this.btnTambahMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTambahMovie.Location = new System.Drawing.Point(443, 58);
            this.btnTambahMovie.Name = "btnTambahMovie";
            this.btnTambahMovie.Size = new System.Drawing.Size(136, 36);
            this.btnTambahMovie.TabIndex = 4;
            this.btnTambahMovie.Text = "Add Movie";
            this.btnTambahMovie.UseVisualStyleBackColor = false;
            this.btnTambahMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(261, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCariMovie
            // 
            this.txtCariMovie.Location = new System.Drawing.Point(10, 63);
            this.txtCariMovie.Multiline = true;
            this.txtCariMovie.Name = "txtCariMovie";
            this.txtCariMovie.Size = new System.Drawing.Size(245, 31);
            this.txtCariMovie.TabIndex = 5;
            // 
            // UC_ManageMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCariMovie);
            this.Controls.Add(this.btnTambahMovie);
            this.Controls.Add(this.labelManageMovie);
            this.Controls.Add(this.flpKatalogMovie);
            this.Controls.Add(this.flpAdminKatalog);
            this.Name = "UC_ManageMovie";
            this.Padding = new System.Windows.Forms.Padding(10, 100, 10, 10);
            this.Size = new System.Drawing.Size(592, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAdminKatalog;
        private System.Windows.Forms.Label labelManageMovie;
        private System.Windows.Forms.FlowLayoutPanel flpKatalogMovie;
        private System.Windows.Forms.Button btnTambahMovie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCariMovie;
    }
}

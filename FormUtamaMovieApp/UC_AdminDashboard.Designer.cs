namespace FormUtamaMovieApp
{
    partial class UC_AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.dgvAktivitasReview = new System.Windows.Forms.DataGridView();
            this.dgvTrendWatchlist = new System.Windows.Forms.DataGridView();
            this.dgvDemografiGenre = new System.Windows.Forms.DataGridView();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelWatchlist = new System.Windows.Forms.Panel();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.panelReview = new System.Windows.Forms.Panel();
            this.movieDBDataSet = new FormUtamaMovieApp.MovieDBDataSet();
            this.watchlistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchlistsTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.WatchlistsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitasReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrendWatchlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemografiGenre)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelWatchlist.SuspendLayout();
            this.panelGenre.SuspendLayout();
            this.panelReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlistsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAktivitasReview
            // 
            this.dgvAktivitasReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivitasReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAktivitasReview.Location = new System.Drawing.Point(0, 0);
            this.dgvAktivitasReview.Name = "dgvAktivitasReview";
            this.dgvAktivitasReview.RowHeadersWidth = 62;
            this.dgvAktivitasReview.RowTemplate.Height = 28;
            this.dgvAktivitasReview.Size = new System.Drawing.Size(546, 135);
            this.dgvAktivitasReview.TabIndex = 0;
            // 
            // dgvTrendWatchlist
            // 
            this.dgvTrendWatchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrendWatchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrendWatchlist.Location = new System.Drawing.Point(0, 0);
            this.dgvTrendWatchlist.Name = "dgvTrendWatchlist";
            this.dgvTrendWatchlist.RowHeadersWidth = 62;
            this.dgvTrendWatchlist.RowTemplate.Height = 28;
            this.dgvTrendWatchlist.Size = new System.Drawing.Size(270, 134);
            this.dgvTrendWatchlist.TabIndex = 1;
            // 
            // dgvDemografiGenre
            // 
            this.dgvDemografiGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemografiGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDemografiGenre.Location = new System.Drawing.Point(0, 0);
            this.dgvDemografiGenre.Name = "dgvDemografiGenre";
            this.dgvDemografiGenre.RowHeadersWidth = 62;
            this.dgvDemografiGenre.RowTemplate.Height = 28;
            this.dgvDemografiGenre.Size = new System.Drawing.Size(270, 134);
            this.dgvDemografiGenre.TabIndex = 2;
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDashboard.Location = new System.Drawing.Point(21, 6);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(332, 32);
            this.labelDashboard.TabIndex = 8;
            this.labelDashboard.Text = "Statistik dan Laporan Movie";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelWatchlist, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelGenre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelReview, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 281);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panelWatchlist
            // 
            this.panelWatchlist.Controls.Add(this.dgvTrendWatchlist);
            this.panelWatchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWatchlist.Location = new System.Drawing.Point(3, 3);
            this.panelWatchlist.Name = "panelWatchlist";
            this.panelWatchlist.Size = new System.Drawing.Size(270, 134);
            this.panelWatchlist.TabIndex = 0;
            // 
            // panelGenre
            // 
            this.panelGenre.Controls.Add(this.dgvDemografiGenre);
            this.panelGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGenre.Location = new System.Drawing.Point(279, 3);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(270, 134);
            this.panelGenre.TabIndex = 1;
            // 
            // panelReview
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelReview, 2);
            this.panelReview.Controls.Add(this.dgvAktivitasReview);
            this.panelReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReview.Location = new System.Drawing.Point(3, 143);
            this.panelReview.Name = "panelReview";
            this.panelReview.Size = new System.Drawing.Size(546, 135);
            this.panelReview.TabIndex = 2;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // watchlistsBindingSource
            // 
            this.watchlistsBindingSource.DataMember = "Watchlists";
            this.watchlistsBindingSource.DataSource = this.movieDBDataSet;
            // 
            // watchlistsTableAdapter
            // 
            this.watchlistsTableAdapter.ClearBeforeFill = true;
            // 
            // UC_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_AdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Size = new System.Drawing.Size(592, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitasReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrendWatchlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemografiGenre)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelWatchlist.ResumeLayout(false);
            this.panelGenre.ResumeLayout(false);
            this.panelReview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlistsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktivitasReview;
        private System.Windows.Forms.DataGridView dgvTrendWatchlist;
        private System.Windows.Forms.DataGridView dgvDemografiGenre;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelWatchlist;
        private System.Windows.Forms.Panel panelGenre;
        private System.Windows.Forms.Panel panelReview;
        private System.Windows.Forms.BindingSource watchlistsBindingSource;
        private MovieDBDataSet movieDBDataSet;
        private MovieDBDataSetTableAdapters.WatchlistsTableAdapter watchlistsTableAdapter;
    }
}

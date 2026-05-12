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
            this.watchlistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new FormUtamaMovieApp.MovieDBDataSet();
            this.vwTrendWatchlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTrendWatchlistTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.vwTrendWatchlistTableAdapter();
            this.vwDemografiGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDemografiGenreTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.vwDemografiGenreTableAdapter();
            this.vwAktivitasReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAktivitasReviewTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.vwAktivitasReviewTableAdapter();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peminatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSimpanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitasReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrendWatchlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemografiGenre)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelWatchlist.SuspendLayout();
            this.panelGenre.SuspendLayout();
            this.panelReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTrendWatchlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDemografiGenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasReviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAktivitasReview
            // 
            this.dgvAktivitasReview.AutoGenerateColumns = false;
            this.dgvAktivitasReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivitasReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.waktuDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.reviewDataGridViewTextBoxColumn});
            this.dgvAktivitasReview.DataSource = this.vwAktivitasReviewBindingSource;
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
            this.dgvTrendWatchlist.AutoGenerateColumns = false;
            this.dgvTrendWatchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrendWatchlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.judulDataGridViewTextBoxColumn,
            this.totalSimpanDataGridViewTextBoxColumn});
            this.dgvTrendWatchlist.DataSource = this.vwTrendWatchlistBindingSource;
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
            this.dgvDemografiGenre.AutoGenerateColumns = false;
            this.dgvDemografiGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemografiGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreDataGridViewTextBoxColumn,
            this.peminatDataGridViewTextBoxColumn});
            this.dgvDemografiGenre.DataSource = this.vwDemografiGenreBindingSource;
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
            // watchlistsBindingSource
            // 
            this.watchlistsBindingSource.DataMember = "Watchlists";
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwTrendWatchlistBindingSource
            // 
            this.vwTrendWatchlistBindingSource.DataMember = "vwTrendWatchlist";
            this.vwTrendWatchlistBindingSource.DataSource = this.movieDBDataSet;
            // 
            // vwTrendWatchlistTableAdapter
            // 
            this.vwTrendWatchlistTableAdapter.ClearBeforeFill = true;
            // 
            // vwDemografiGenreBindingSource
            // 
            this.vwDemografiGenreBindingSource.DataMember = "vwDemografiGenre";
            this.vwDemografiGenreBindingSource.DataSource = this.movieDBDataSet;
            // 
            // vwDemografiGenreTableAdapter
            // 
            this.vwDemografiGenreTableAdapter.ClearBeforeFill = true;
            // 
            // vwAktivitasReviewBindingSource
            // 
            this.vwAktivitasReviewBindingSource.DataMember = "vwAktivitasReview";
            this.vwAktivitasReviewBindingSource.DataSource = this.movieDBDataSet;
            // 
            // vwAktivitasReviewTableAdapter
            // 
            this.vwAktivitasReviewTableAdapter.ClearBeforeFill = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // peminatDataGridViewTextBoxColumn
            // 
            this.peminatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.peminatDataGridViewTextBoxColumn.DataPropertyName = "Peminat";
            this.peminatDataGridViewTextBoxColumn.HeaderText = "Peminat";
            this.peminatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.peminatDataGridViewTextBoxColumn.Name = "peminatDataGridViewTextBoxColumn";
            // 
            // judulDataGridViewTextBoxColumn
            // 
            this.judulDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.judulDataGridViewTextBoxColumn.DataPropertyName = "Judul";
            this.judulDataGridViewTextBoxColumn.HeaderText = "Judul";
            this.judulDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.judulDataGridViewTextBoxColumn.Name = "judulDataGridViewTextBoxColumn";
            // 
            // totalSimpanDataGridViewTextBoxColumn
            // 
            this.totalSimpanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalSimpanDataGridViewTextBoxColumn.DataPropertyName = "Total Simpan";
            this.totalSimpanDataGridViewTextBoxColumn.HeaderText = "Total Simpan";
            this.totalSimpanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalSimpanDataGridViewTextBoxColumn.Name = "totalSimpanDataGridViewTextBoxColumn";
            // 
            // waktuDataGridViewTextBoxColumn
            // 
            this.waktuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "Waktu";
            this.waktuDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "⭐";
            this.dataGridViewTextBoxColumn1.HeaderText = "⭐";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // reviewDataGridViewTextBoxColumn
            // 
            this.reviewDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reviewDataGridViewTextBoxColumn.DataPropertyName = "Review";
            this.reviewDataGridViewTextBoxColumn.HeaderText = "Review";
            this.reviewDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reviewDataGridViewTextBoxColumn.Name = "reviewDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.watchlistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTrendWatchlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDemografiGenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasReviewBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource vwAktivitasReviewBindingSource;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource vwTrendWatchlistBindingSource;
        private System.Windows.Forms.BindingSource vwDemografiGenreBindingSource;
        private MovieDBDataSetTableAdapters.vwTrendWatchlistTableAdapter vwTrendWatchlistTableAdapter;
        private MovieDBDataSetTableAdapters.vwDemografiGenreTableAdapter vwDemografiGenreTableAdapter;
        private MovieDBDataSetTableAdapters.vwAktivitasReviewTableAdapter vwAktivitasReviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSimpanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peminatDataGridViewTextBoxColumn;
    }
}

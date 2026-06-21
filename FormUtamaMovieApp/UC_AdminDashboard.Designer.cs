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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvAktivitasReview = new System.Windows.Forms.DataGridView();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelWatchlist = new System.Windows.Forms.Panel();
            this.chartTopMovie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.chartGenre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelReview = new System.Windows.Forms.Panel();
            this.watchlistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCetak = new System.Windows.Forms.Button();
            this.vwAktivitasReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new FormUtamaMovieApp.MovieDBDataSet();
            this.vwTrendWatchlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDemografiGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTrendWatchlistTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.vwTrendWatchlistTableAdapter();
            this.vwDemografiGenreTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.vwDemografiGenreTableAdapter();
            this.vwAktivitasReviewTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.vwAktivitasReviewTableAdapter();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitasReview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelWatchlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMovie)).BeginInit();
            this.panelGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenre)).BeginInit();
            this.panelReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasReviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTrendWatchlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDemografiGenreBindingSource)).BeginInit();
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
            this.panelWatchlist.Controls.Add(this.chartTopMovie);
            this.panelWatchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWatchlist.Location = new System.Drawing.Point(3, 3);
            this.panelWatchlist.Name = "panelWatchlist";
            this.panelWatchlist.Size = new System.Drawing.Size(270, 134);
            this.panelWatchlist.TabIndex = 0;
            // 
            // chartTopMovie
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTopMovie.ChartAreas.Add(chartArea1);
            this.chartTopMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTopMovie.Legends.Add(legend1);
            this.chartTopMovie.Location = new System.Drawing.Point(0, 0);
            this.chartTopMovie.Name = "chartTopMovie";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTopMovie.Series.Add(series1);
            this.chartTopMovie.Size = new System.Drawing.Size(270, 134);
            this.chartTopMovie.TabIndex = 0;
            this.chartTopMovie.Text = "chart1";
            // 
            // panelGenre
            // 
            this.panelGenre.Controls.Add(this.chartGenre);
            this.panelGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGenre.Location = new System.Drawing.Point(279, 3);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(270, 134);
            this.panelGenre.TabIndex = 1;
            // 
            // chartGenre
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGenre.ChartAreas.Add(chartArea2);
            this.chartGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartGenre.Legends.Add(legend2);
            this.chartGenre.Location = new System.Drawing.Point(0, 0);
            this.chartGenre.Name = "chartGenre";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGenre.Series.Add(series2);
            this.chartGenre.Size = new System.Drawing.Size(270, 134);
            this.chartGenre.TabIndex = 0;
            this.chartGenre.Text = "chart2";
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
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(481, 43);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(88, 31);
            this.btnCetak.TabIndex = 13;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // vwAktivitasReviewBindingSource
            // 
            this.vwAktivitasReviewBindingSource.DataMember = "vwAktivitasReview";
            this.vwAktivitasReviewBindingSource.DataSource = this.movieDBDataSet;
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
            // vwDemografiGenreBindingSource
            // 
            this.vwDemografiGenreBindingSource.DataMember = "vwDemografiGenre";
            this.vwDemografiGenreBindingSource.DataSource = this.movieDBDataSet;
            // 
            // vwTrendWatchlistTableAdapter
            // 
            this.vwTrendWatchlistTableAdapter.ClearBeforeFill = true;
            // 
            // vwDemografiGenreTableAdapter
            // 
            this.vwDemografiGenreTableAdapter.ClearBeforeFill = true;
            // 
            // vwAktivitasReviewTableAdapter
            // 
            this.vwAktivitasReviewTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rating";
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
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_AdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Size = new System.Drawing.Size(592, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitasReview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelWatchlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMovie)).EndInit();
            this.panelGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGenre)).EndInit();
            this.panelReview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchlistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasReviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTrendWatchlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDemografiGenreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktivitasReview;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopMovie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenre;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
    }
}

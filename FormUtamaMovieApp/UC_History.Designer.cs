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
            this.components = new System.ComponentModel.Container();
            this.btnDeleteHistory = new System.Windows.Forms.Button();
            this.labelDaftarHistory = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.movieDBDataSet = new FormUtamaMovieApp.MovieDBDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new FormUtamaMovieApp.MovieDBDataSetTableAdapters.HistoryTableAdapter();
            this.historyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalnontonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteHistory
            // 
            this.btnDeleteHistory.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHistory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteHistory.Location = new System.Drawing.Point(433, 39);
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
            this.labelDaftarHistory.Location = new System.Drawing.Point(23, 45);
            this.labelDaftarHistory.Name = "labelDaftarHistory";
            this.labelDaftarHistory.Size = new System.Drawing.Size(177, 32);
            this.labelDaftarHistory.TabIndex = 7;
            this.labelDaftarHistory.Text = "Daftar History";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.movieidDataGridViewTextBoxColumn,
            this.tanggalnontonDataGridViewTextBoxColumn});
            this.dgvHistory.DataSource = this.historyBindingSource;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(20, 80);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 28;
            this.dgvHistory.Size = new System.Drawing.Size(552, 281);
            this.dgvHistory.TabIndex = 9;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.movieDBDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // historyidDataGridViewTextBoxColumn
            // 
            this.historyidDataGridViewTextBoxColumn.DataPropertyName = "history_id";
            this.historyidDataGridViewTextBoxColumn.HeaderText = "history_id";
            this.historyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.historyidDataGridViewTextBoxColumn.Name = "historyidDataGridViewTextBoxColumn";
            this.historyidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "movie_id";
            this.movieidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            // 
            // tanggalnontonDataGridViewTextBoxColumn
            // 
            this.tanggalnontonDataGridViewTextBoxColumn.DataPropertyName = "tanggal_nonton";
            this.tanggalnontonDataGridViewTextBoxColumn.HeaderText = "tanggal_nonton";
            this.tanggalnontonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalnontonDataGridViewTextBoxColumn.Name = "tanggalnontonDataGridViewTextBoxColumn";
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.btnDeleteHistory);
            this.Controls.Add(this.labelDaftarHistory);
            this.Controls.Add(this.dgvHistory);
            this.Name = "UC_History";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Size = new System.Drawing.Size(592, 381);
            this.Load += new System.EventHandler(this.UC_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteHistory;
        private System.Windows.Forms.Label labelDaftarHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalnontonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private MovieDBDataSet movieDBDataSet;
        private MovieDBDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
    }
}

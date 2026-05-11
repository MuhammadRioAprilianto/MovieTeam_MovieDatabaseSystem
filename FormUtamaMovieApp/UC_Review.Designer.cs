namespace FormUtamaMovieApp
{
    partial class UC_Review
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
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.dgvComment = new System.Windows.Forms.DataGridView();
            this.btnUpdateComment = new System.Windows.Forms.Button();
            this.labelReview = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.numDurasi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteComment.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteComment.Location = new System.Drawing.Point(489, 39);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(80, 35);
            this.btnDeleteComment.TabIndex = 8;
            this.btnDeleteComment.Text = "delete";
            this.btnDeleteComment.UseVisualStyleBackColor = false;
            // 
            // dgvComment
            // 
            this.dgvComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvComment, 2);
            this.dgvComment.Location = new System.Drawing.Point(3, 70);
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.RowHeadersWidth = 62;
            this.dgvComment.RowTemplate.Height = 28;
            this.dgvComment.Size = new System.Drawing.Size(546, 208);
            this.dgvComment.TabIndex = 9;
            this.dgvComment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComment_CellContentClick);
            // 
            // btnUpdateComment
            // 
            this.btnUpdateComment.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateComment.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateComment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateComment.Location = new System.Drawing.Point(403, 39);
            this.btnUpdateComment.Name = "btnUpdateComment";
            this.btnUpdateComment.Size = new System.Drawing.Size(80, 35);
            this.btnUpdateComment.TabIndex = 10;
            this.btnUpdateComment.Text = "Update";
            this.btnUpdateComment.UseVisualStyleBackColor = false;
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelReview.Location = new System.Drawing.Point(23, 42);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(173, 32);
            this.labelReview.TabIndex = 11;
            this.labelReview.Text = "Daftar Review";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvComment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtKomentar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numDurasi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.84342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.15659F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 281);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKomentar.Location = new System.Drawing.Point(279, 3);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(270, 61);
            this.txtKomentar.TabIndex = 10;
            // 
            // numDurasi
            // 
            this.numDurasi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numDurasi.Location = new System.Drawing.Point(3, 38);
            this.numDurasi.Name = "numDurasi";
            this.numDurasi.Size = new System.Drawing.Size(270, 26);
            this.numDurasi.TabIndex = 11;
            // 
            // UC_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.btnUpdateComment);
            this.Controls.Add(this.btnDeleteComment);
            this.Name = "UC_Review";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Size = new System.Drawing.Size(592, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.DataGridView dgvComment;
        private System.Windows.Forms.Button btnUpdateComment;
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.NumericUpDown numDurasi;
    }
}

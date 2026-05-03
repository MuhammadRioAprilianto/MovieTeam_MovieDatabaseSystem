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
            this.labelDaftarReview = new System.Windows.Forms.Label();
            this.dgvComment = new System.Windows.Forms.DataGridView();
            this.btnUpdateComment = new System.Windows.Forms.Button();
            this.labelReview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
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
            // labelDaftarReview
            // 
            this.labelDaftarReview.AutoSize = true;
            this.labelDaftarReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarReview.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDaftarReview.Location = new System.Drawing.Point(38, 98);
            this.labelDaftarReview.Name = "labelDaftarReview";
            this.labelDaftarReview.Size = new System.Drawing.Size(173, 32);
            this.labelDaftarReview.TabIndex = 7;
            this.labelDaftarReview.Text = "Daftar Review";
            // 
            // dgvComment
            // 
            this.dgvComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComment.Location = new System.Drawing.Point(20, 80);
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.RowHeadersWidth = 62;
            this.dgvComment.RowTemplate.Height = 28;
            this.dgvComment.Size = new System.Drawing.Size(552, 281);
            this.dgvComment.TabIndex = 9;
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
            // UC_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.btnUpdateComment);
            this.Controls.Add(this.dgvComment);
            this.Controls.Add(this.btnDeleteComment);
            this.Controls.Add(this.labelDaftarReview);
            this.Name = "UC_Review";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Size = new System.Drawing.Size(592, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.Label labelDaftarReview;
        private System.Windows.Forms.DataGridView dgvComment;
        private System.Windows.Forms.Button btnUpdateComment;
        private System.Windows.Forms.Label labelReview;
    }
}

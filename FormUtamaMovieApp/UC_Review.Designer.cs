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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteComment.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteComment.Location = new System.Drawing.Point(401, 15);
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
            this.labelDaftarReview.Location = new System.Drawing.Point(18, 18);
            this.labelDaftarReview.Name = "labelDaftarReview";
            this.labelDaftarReview.Size = new System.Drawing.Size(173, 32);
            this.labelDaftarReview.TabIndex = 7;
            this.labelDaftarReview.Text = "Daftar Review";
            // 
            // dgvComment
            // 
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComment.Location = new System.Drawing.Point(17, 57);
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.RowHeadersWidth = 62;
            this.dgvComment.RowTemplate.Height = 28;
            this.dgvComment.Size = new System.Drawing.Size(464, 189);
            this.dgvComment.TabIndex = 9;
            // 
            // btnUpdateComment
            // 
            this.btnUpdateComment.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateComment.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateComment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateComment.Location = new System.Drawing.Point(315, 16);
            this.btnUpdateComment.Name = "btnUpdateComment";
            this.btnUpdateComment.Size = new System.Drawing.Size(80, 35);
            this.btnUpdateComment.TabIndex = 10;
            this.btnUpdateComment.Text = "Update";
            this.btnUpdateComment.UseVisualStyleBackColor = false;
            // 
            // UC_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.btnUpdateComment);
            this.Controls.Add(this.dgvComment);
            this.Controls.Add(this.btnDeleteComment);
            this.Controls.Add(this.labelDaftarReview);
            this.Name = "UC_Review";
            this.Size = new System.Drawing.Size(497, 262);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.Label labelDaftarReview;
        private System.Windows.Forms.DataGridView dgvComment;
        private System.Windows.Forms.Button btnUpdateComment;
    }
}

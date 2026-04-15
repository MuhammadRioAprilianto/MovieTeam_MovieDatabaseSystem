namespace FormUtamaMovieApp
{
    partial class FormIsiReview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJudulFilm = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudulFilm
            // 
            this.lblJudulFilm.AutoSize = true;
            this.lblJudulFilm.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulFilm.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblJudulFilm.Location = new System.Drawing.Point(382, 68);
            this.lblJudulFilm.Name = "lblJudulFilm";
            this.lblJudulFilm.Size = new System.Drawing.Size(74, 35);
            this.lblJudulFilm.TabIndex = 0;
            this.lblJudulFilm.Text = "judul";
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(136, 145);
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(120, 26);
            this.numRating.TabIndex = 1;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(136, 177);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(514, 118);
            this.txtKomentar.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Yellow;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSimpan.Location = new System.Drawing.Point(570, 314);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 35);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Save";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Yellow;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBatal.Location = new System.Drawing.Point(484, 314);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 35);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Cancel";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // FormIsiReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.lblJudulFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIsiReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Review";
            this.Load += new System.EventHandler(this.FormIsiReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudulFilm;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
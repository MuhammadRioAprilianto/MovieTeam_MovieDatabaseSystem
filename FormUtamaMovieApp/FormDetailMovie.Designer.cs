namespace FormUtamaMovieApp
{
    partial class FormDetailMovie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJudulFilm = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnRating = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnRating);
            this.panel1.Controls.Add(this.txtDeskripsi);
            this.panel1.Controls.Add(this.lblJudulFilm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 211);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 239);
            this.panel2.TabIndex = 1;
            // 
            // lblJudulFilm
            // 
            this.lblJudulFilm.AutoSize = true;
            this.lblJudulFilm.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulFilm.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblJudulFilm.Location = new System.Drawing.Point(12, 17);
            this.lblJudulFilm.Name = "lblJudulFilm";
            this.lblJudulFilm.Size = new System.Drawing.Size(74, 35);
            this.lblJudulFilm.TabIndex = 1;
            this.lblJudulFilm.Text = "judul";
            this.lblJudulFilm.Click += new System.EventHandler(this.FormDetailMovie_Load);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(12, 64);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(776, 135);
            this.txtDeskripsi.TabIndex = 2;
            this.txtDeskripsi.Click += new System.EventHandler(this.FormDetailMovie_Load);
            // 
            // btnRating
            // 
            this.btnRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRating.BackColor = System.Drawing.Color.Yellow;
            this.btnRating.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRating.Location = new System.Drawing.Point(652, 21);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(136, 36);
            this.btnRating.TabIndex = 16;
            this.btnRating.Text = "Rate";
            this.btnRating.UseVisualStyleBackColor = false;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // FormDetailMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailMovie";
            this.Text = "FormDetailMovie";
            this.Click += new System.EventHandler(this.FormDetailMovie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblJudulFilm;
        private System.Windows.Forms.Button btnRating;
    }
}
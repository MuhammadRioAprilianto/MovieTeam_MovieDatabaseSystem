namespace FormUtamaMovieApp
{
    partial class UC_MovieItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJudulMovie = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnWatchlistToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblJudulMovie
            // 
            this.lblJudulMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJudulMovie.AutoSize = true;
            this.lblJudulMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulMovie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJudulMovie.Location = new System.Drawing.Point(52, 185);
            this.lblJudulMovie.Name = "lblJudulMovie";
            this.lblJudulMovie.Size = new System.Drawing.Size(103, 20);
            this.lblJudulMovie.TabIndex = 1;
            this.lblJudulMovie.Text = "Judul Movie";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPlay.Location = new System.Drawing.Point(32, 216);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(136, 36);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnRating
            // 
            this.btnRating.BackColor = System.Drawing.Color.Yellow;
            this.btnRating.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRating.Location = new System.Drawing.Point(32, 258);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(136, 36);
            this.btnRating.TabIndex = 12;
            this.btnRating.Text = "Rating";
            this.btnRating.UseVisualStyleBackColor = false;
            // 
            // btnWatchlistToggle
            // 
            this.btnWatchlistToggle.BackColor = System.Drawing.Color.Yellow;
            this.btnWatchlistToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchlistToggle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnWatchlistToggle.Location = new System.Drawing.Point(32, 300);
            this.btnWatchlistToggle.Name = "btnWatchlistToggle";
            this.btnWatchlistToggle.Size = new System.Drawing.Size(136, 36);
            this.btnWatchlistToggle.TabIndex = 13;
            this.btnWatchlistToggle.UseVisualStyleBackColor = false;
            // 
            // UC_MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnWatchlistToggle);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblJudulMovie);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_MovieItem";
            this.Size = new System.Drawing.Size(200, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJudulMovie;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.Button btnWatchlistToggle;
    }
}

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
            this.panelDasar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWatchlistToggle = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblJudulMovie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDasar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDasar
            // 
            this.panelDasar.Controls.Add(this.panel1);
            this.panelDasar.Controls.Add(this.pictureBox1);
            this.panelDasar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDasar.Location = new System.Drawing.Point(10, 10);
            this.panelDasar.Name = "panelDasar";
            this.panelDasar.Size = new System.Drawing.Size(146, 278);
            this.panelDasar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWatchlistToggle);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.lblJudulMovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 122);
            this.panel1.TabIndex = 3;
            // 
            // btnWatchlistToggle
            // 
            this.btnWatchlistToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWatchlistToggle.BackColor = System.Drawing.Color.Yellow;
            this.btnWatchlistToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchlistToggle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnWatchlistToggle.Location = new System.Drawing.Point(5, 79);
            this.btnWatchlistToggle.Name = "btnWatchlistToggle";
            this.btnWatchlistToggle.Size = new System.Drawing.Size(136, 36);
            this.btnWatchlistToggle.TabIndex = 17;
            this.btnWatchlistToggle.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPlay.Location = new System.Drawing.Point(5, 39);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(136, 36);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // lblJudulMovie
            // 
            this.lblJudulMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJudulMovie.AutoSize = true;
            this.lblJudulMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulMovie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJudulMovie.Location = new System.Drawing.Point(23, 16);
            this.lblJudulMovie.Name = "lblJudulMovie";
            this.lblJudulMovie.Size = new System.Drawing.Size(103, 20);
            this.lblJudulMovie.TabIndex = 14;
            this.lblJudulMovie.Text = "Judul Movie";
            this.lblJudulMovie.Click += new System.EventHandler(this.lblJudulMovie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UC_MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelDasar);
            this.Name = "UC_MovieItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(166, 298);
            this.panelDasar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDasar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWatchlistToggle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblJudulMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

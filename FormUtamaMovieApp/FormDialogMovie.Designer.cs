namespace FormUtamaMovieApp
{
    partial class FormDialogMovie
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
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.numDurasi = new System.Windows.Forms.NumericUpDown();
            this.txtDeskripsi = new System.Windows.Forms.RichTextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDeskripsi = new System.Windows.Forms.Label();
            this.labelDurasi = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(239, 114);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 28);
            this.cbGenre.TabIndex = 0;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(239, 75);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(266, 26);
            this.txtJudul.TabIndex = 1;
            // 
            // numDurasi
            // 
            this.numDurasi.Location = new System.Drawing.Point(239, 153);
            this.numDurasi.Name = "numDurasi";
            this.numDurasi.Size = new System.Drawing.Size(120, 26);
            this.numDurasi.TabIndex = 2;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(239, 192);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(440, 115);
            this.txtDeskripsi.TabIndex = 3;
            this.txtDeskripsi.Text = "";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Location = new System.Drawing.Point(127, 78);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(47, 20);
            this.labelJudul.TabIndex = 6;
            this.labelJudul.Text = "Judul";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(127, 117);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 20);
            this.labelGenre.TabIndex = 7;
            this.labelGenre.Text = "Genre";
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Location = new System.Drawing.Point(127, 192);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(74, 20);
            this.labelDeskripsi.TabIndex = 8;
            this.labelDeskripsi.Text = "Deskripsi";
            // 
            // labelDurasi
            // 
            this.labelDurasi.AutoSize = true;
            this.labelDurasi.Location = new System.Drawing.Point(127, 155);
            this.labelDurasi.Name = "labelDurasi";
            this.labelDurasi.Size = new System.Drawing.Size(55, 20);
            this.labelDurasi.TabIndex = 9;
            this.labelDurasi.Text = "Durasi";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(525, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(605, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menit";
            // 
            // FormDialogMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelDurasi);
            this.Controls.Add(this.labelDeskripsi);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.numDurasi);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.cbGenre);
            this.Name = "FormDialogMovie";
            this.Text = "Form Movie";
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.NumericUpDown numDurasi;
        private System.Windows.Forms.RichTextBox txtDeskripsi;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Label labelDurasi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}
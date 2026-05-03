using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class FormDetailMovie : Form
    {
        private int _movieId;

        public FormDetailMovie(int id)
        {
            InitializeComponent();
            this._movieId = id;
            this.Load += new EventHandler(FormDetailMovie_Load);

            if (btnRating != null)
            {
                btnRating.Click += new EventHandler(btnRating_Click);
            }
            SetupUI();
        }

        private void SetupUI()
        {
            txtDeskripsi.ReadOnly = true;
            txtDeskripsi.Multiline = true;
            txtDeskripsi.BackColor = Color.Black;
            txtDeskripsi.ForeColor = Color.White;
            txtDeskripsi.BorderStyle = BorderStyle.FixedSingle;

            lblJudulFilm.ForeColor = Color.White;
            lblJudulFilm.Text = "Loading...";
        }

        private void FormDetailMovie_Load(object sender, EventArgs e)
        {
            LoadDetailMovie();
        }

        private void LoadDetailMovie()
        {
            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT judul, deskripsi FROM Movies WHERE movie_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _movieId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblJudulFilm.Text = reader["judul"].ToString().ToUpper();
                                txtDeskripsi.Text = reader["deskripsi"].ToString();

                                Console.WriteLine("Data Berhasil di-Update ke UI");
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ditemukan di database untuk ID: " + _movieId);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal koneksi database: " + ex.Message);
                }
            }
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            if (SesiUser.IdUser == 0)
            {
                MessageBox.Show("Silakan login untuk memberikan ulasan.", "Akses Ditolak");
                return;
            }

            // Buka form review
            FormIsiReview popUp = new FormIsiReview(this._movieId, lblJudulFilm.Text);
            popUp.ShowDialog();
        }
    }
}
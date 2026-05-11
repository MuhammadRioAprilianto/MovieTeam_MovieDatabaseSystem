using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_MovieItem : UserControl
    {
        private int idMovie;
        private string judulMovie;
        private bool isInWatchlist = false;

        public UC_MovieItem()
        {
            InitializeComponent();
            btnPlay.Click += btnPlay_Click;
            btnWatchlistToggle.Click += btnWatchlistToggle_Click;
        }

        public void SetDataFilm(int id, string judul)
        {
            this.idMovie = id;
            this.judulMovie = judul;
            lblJudulMovie.Text = judul;
            CekStatusWatchlist();
        }

        private void CekStatusWatchlist()
        {
            if (SesiUser.IdUser == 0) return;

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Watchlists WHERE user_id=@uid AND movie_id=@mid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);
                        cmd.Parameters.AddWithValue("@mid", this.idMovie);
                        int count = (int)cmd.ExecuteScalar();
                        isInWatchlist = count > 0;
                        UpdateTampilanTombolWatchlist();
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error cek watchlist: " + ex.Message); }
            }
        }

        private void UpdateTampilanTombolWatchlist()
        {
            if (isInWatchlist)
            {
                btnWatchlistToggle.Text = "❌ Hapus Watchlist";
                btnWatchlistToggle.BackColor = Color.LightCoral;
            }
            else
            {
                btnWatchlistToggle.Text = "➕ Add Watchlist";
                btnWatchlistToggle.BackColor = Color.LightGreen;
            }
        }

        private void btnWatchlistToggle_Click(object sender, EventArgs e)
        {
            if (SesiUser.IdUser == 0)
            {
                MessageBox.Show("Silakan login terlebih dahulu untuk mengatur Watchlist.", "Akses Ditolak");
                return;
            }

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Panggil Stored Procedure sp_ToggleWatchlist
                    using (SqlCommand cmd = new SqlCommand("sp_ToggleWatchlist", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);
                        cmd.Parameters.AddWithValue("@mid", this.idMovie);

                        cmd.ExecuteNonQuery();
                    }

                    // Update status di UI
                    isInWatchlist = !isInWatchlist;
                    UpdateTampilanTombolWatchlist();
                }
                catch (Exception ex) { MessageBox.Show("Gagal update watchlist: " + ex.Message, "Error"); }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (SesiUser.IdUser == 0)
            {
                MessageBox.Show("Silakan login untuk memutar film dan mencatat riwayat.", "Akses Ditolak");
                return;
            }
            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO History (user_id, movie_id, tanggal_nonton) VALUES (@uid, @mid, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);
                        cmd.Parameters.AddWithValue("@mid", this.idMovie);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mencatat history: " + ex.Message);
                }
            }

            FormDetailMovie frmDetail = new FormDetailMovie(this.idMovie);
            frmDetail.ShowDialog();
        }

        private void lblJudulMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
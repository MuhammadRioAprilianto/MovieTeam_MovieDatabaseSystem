using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_Watchlist : UserControl
    {
        public UC_Watchlist()
        {
            InitializeComponent();
            LoadDataWatchlist();
        }

        public void LoadDataWatchlist()
        {
            flpWatchlist.Controls.Clear();

            if (SesiUser.IdUser == 0)
            {
                Label lblPesan = new Label();
                lblPesan.Text = "Silakan login untuk melihat Watchlist Anda.";
                lblPesan.AutoSize = true;
                flpWatchlist.Controls.Add(lblPesan);
                return;
            }

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. UPDATE: Tambahkan poster_image pada query
                    string query = "SELECT movie_id, judul, poster_image FROM vwUserWatchlist WHERE user_id = @uid";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Label lblKosong = new Label();
                                lblKosong.Text = "Watchlist Anda masih kosong.";
                                lblKosong.AutoSize = true;
                                flpWatchlist.Controls.Add(lblKosong);
                                return;
                            }

                            while (reader.Read())
                            {
                                UC_MovieItem kartuFilm = new UC_MovieItem();

                                int id = Convert.ToInt32(reader["movie_id"]);
                                string judul = reader["judul"].ToString();

                                // 2. UPDATE: Ambil data gambar biner dari database
                                byte[] poster = null;
                                if (reader["poster_image"] != DBNull.Value)
                                {
                                    poster = (byte[])reader["poster_image"];
                                }

                                // 3. UPDATE: Masukkan 3 parameter (id, judul, poster) ke SetDataFilm
                                kartuFilm.SetDataFilm(id, judul, poster);

                                kartuFilm.Margin = new Padding(10);

                                flpWatchlist.Controls.Add(kartuFilm);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat Watchlist: " + ex.Message);
                }
            }
        }
    }
}
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
                lblPesan.ForeColor = System.Drawing.Color.White;
                flpWatchlist.Controls.Add(lblPesan);
                return;
            }

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT m.movie_id, m.judul 
                        FROM Watchlists w
                        INNER JOIN Movies m ON w.movie_id = m.movie_id
                        WHERE w.user_id = @uid
                          AND m.is_deleted = 0";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UC_MovieItem kartuFilm = new UC_MovieItem();
                                int id = Convert.ToInt32(reader["movie_id"]);
                                string judul = reader["judul"].ToString();

                                kartuFilm.SetDataFilm(id, judul);

                                kartuFilm.Margin = new Padding(10);

                                flpWatchlist.Controls.Add(kartuFilm);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat Watchlist: " + ex.Message, "Error");
                }
            }
        }
    }
}
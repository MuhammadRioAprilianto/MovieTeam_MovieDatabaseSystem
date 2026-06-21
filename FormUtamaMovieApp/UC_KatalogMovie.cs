using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_KatalogMovie : UserControl
    {
        public UC_KatalogMovie()
        {
            InitializeComponent();
            LoadDataKatalog();
        }

        public void LoadDataKatalog(string keyword = "")
        {
            flpKatalogMovie.Controls.Clear();

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_SearchMovie", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@keyword", keyword);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UC_MovieItem kartuFilm = new UC_MovieItem();

                                int id = Convert.ToInt32(reader["movie_id"]);
                                string judul = reader["judul"].ToString();

                                byte[] poster = null;
                                if (reader["poster_image"] != DBNull.Value)
                                {
                                    poster = (byte[])reader["poster_image"];
                                }

                                kartuFilm.SetDataFilm(id, judul, poster);

                                kartuFilm.Margin = new Padding(15);
                                flpKatalogMovie.Controls.Add(kartuFilm);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataKatalog(txtSearch.Text.Trim());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
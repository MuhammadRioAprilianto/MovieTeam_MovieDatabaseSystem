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

        private void UC_KatalogMovie_Load(object sender, EventArgs e)
        {
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
                    string query = "SELECT movie_id, judul FROM Movies WHERE is_deleted = 0";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " AND judul LIKE @keyword";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(keyword))
                        {
                            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UC_MovieItem kartuFilm = new UC_MovieItem();
                                int id = Convert.ToInt32(reader["movie_id"]);
                                string judul = reader["judul"].ToString();

                                kartuFilm.SetDataFilm(id, judul);

                                kartuFilm.Width = 200;
                                kartuFilm.Height = 350;
                                kartuFilm.Margin = new Padding(10);

                                flpKatalogMovie.Controls.Add(kartuFilm);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Waduh, Error Database: " + ex.Message, "Error");
                }
            }
        }
    }
}
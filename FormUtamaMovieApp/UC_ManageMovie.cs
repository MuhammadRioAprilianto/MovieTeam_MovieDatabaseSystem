using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_ManageMovie : UserControl
    {
        public UC_ManageMovie()
        {
            InitializeComponent();
            LoadKatalogAdmin();
        }

        public void LoadKatalogAdmin(string search = "")
        {
            flpKatalogMovie.Controls.Clear();

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT movie_id, judul FROM Movies WHERE is_deleted = 0";
                    if (!string.IsNullOrEmpty(search)) query += " AND judul LIKE @s";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(search)) cmd.Parameters.AddWithValue("@s", "%" + search + "%");

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Koneksi OK, tapi data di tabel Movies kosong atau is_deleted=1");
                    }

                    while (dr.Read())
                    {
                        UC_MovieCardAdmin card = new UC_MovieCardAdmin();
                        card.SetData(Convert.ToInt32(dr["movie_id"]), dr["judul"].ToString());
                        card.Margin = new Padding(10);

                        flpKatalogMovie.Controls.Add(card);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Load: " + ex.Message);
                }
            }
        }
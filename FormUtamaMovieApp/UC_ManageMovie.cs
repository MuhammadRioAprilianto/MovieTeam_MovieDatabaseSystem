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
                    using (SqlCommand cmd = new SqlCommand("sp_SearchMovieAdmin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@keyword", search);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows && string.IsNullOrEmpty(search))
                            {
                                Label lbl = new Label { Text = "Belum ada data film.", AutoSize = true };
                                flpKatalogMovie.Controls.Add(lbl);
                                return;
                            }

                            while (dr.Read())
                            {
                                UC_MovieCardAdmin card = new UC_MovieCardAdmin();
                                card.SetData(Convert.ToInt32(dr["movie_id"]), dr["judul"].ToString());
                                card.Margin = new Padding(10);
                                flpKatalogMovie.Controls.Add(card);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Load: " + ex.Message);
                }
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            FormDialogMovie frm = new FormDialogMovie();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadKatalogAdmin();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadKatalogAdmin(txtCariMovie.Text);
        }
    }
}
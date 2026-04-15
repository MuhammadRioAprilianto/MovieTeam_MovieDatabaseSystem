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
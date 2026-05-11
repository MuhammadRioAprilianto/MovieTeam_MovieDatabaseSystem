using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_AdminDashboard : UserControl
    {
        public UC_AdminDashboard()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadAllReports();
        }

        public void LoadAllReports()
        {
            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();

                    FillGrid("SELECT * FROM vwTrendWatchlist ORDER BY [Total Simpan] DESC", dgvTrendWatchlist, conn);

                    FillGrid("SELECT * FROM vwDemografiGenre", dgvDemografiGenre, conn);

                    FillGrid("SELECT * FROM vwAktivitasReview ORDER BY Waktu DESC", dgvAktivitasReview, conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Laporan: " + ex.Message);
                }
            }
        }

        private void FillGrid(string query, DataGridView dgv, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
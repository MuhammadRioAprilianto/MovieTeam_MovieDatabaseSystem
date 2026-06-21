using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 

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

                    FillChart(
                        "SELECT * FROM vwTrendWatchlist ORDER BY [Total Simpan] DESC",
                        chartTopMovie,
                        "Judul",
                        "Total Simpan",
                        SeriesChartType.Bar,
                        conn
                    );

                    FillChart(
                        "SELECT * FROM vwDemografiGenre",
                        chartGenre,
                        "Genre",
                        "Peminat",
                        SeriesChartType.Doughnut,
                        conn
                    );

                    FillGrid("SELECT * FROM vwAktivitasReview ORDER BY Waktu DESC", dgvAktivitasReview, conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Laporan: " + ex.Message);
                }
            }
        }

        private void FillChart(string query, Chart chartControl, string colX, string colY, SeriesChartType type, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chartControl.DataSource = dt;

            chartControl.Series[0].XValueMember = colX;
            chartControl.Series[0].YValueMembers = colY;

            chartControl.Series[0].ChartType = type;
            chartControl.Series[0].IsValueShownAsLabel = true;

            chartControl.DataBind();
        }

        private void FillGrid(string query, DataGridView dgv, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtReview = new DataTable();
                DataTable dtTopMovie = new DataTable();
                DataTable dtGenre = new DataTable();

                using (SqlConnection conn = KoneksiDB.GetConnection())
                {
                    conn.Open();

                    using (SqlDataAdapter daReview = new SqlDataAdapter("SELECT * FROM vwAktivitasReview ORDER BY Waktu DESC", conn))
                    {
                        daReview.Fill(dtReview);
                    }

                    using (SqlDataAdapter daTopMovie = new SqlDataAdapter("SELECT Judul, [Total Simpan] AS TotalSimpan FROM vwTrendWatchlist", conn))
                    {
                        daTopMovie.Fill(dtTopMovie);
                    }

                    using (SqlDataAdapter daGenre = new SqlDataAdapter("SELECT Genre, Peminat FROM vwDemografiGenre", conn))
                    {
                        daGenre.Fill(dtGenre);
                    }
                } 
                rptMovie rpt = new rptMovie();
                rpt.SetDataSource(dtReview);

                rpt.Subreports["SubTopMovie"].SetDataSource(dtTopMovie);
                rpt.Subreports["SubGenre"].SetDataSource(dtGenre);

                FormViewerReport frmViewer = new FormViewerReport();
                frmViewer.crystalReportViewer1.ReportSource = rpt;
                frmViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
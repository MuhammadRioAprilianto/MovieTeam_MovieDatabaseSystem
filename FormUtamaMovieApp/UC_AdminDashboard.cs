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

                    FillGrid(@"SELECT TOP 5 m.judul AS 'Judul', COUNT(w.movie_id) AS 'Total Simpan' 
                               FROM Watchlists w JOIN Movies m ON w.movie_id = m.movie_id 
                               GROUP BY m.judul ORDER BY [Total Simpan] DESC", dgvTrendWatchlist, conn);

                    FillGrid(@"SELECT g.nama_genre AS 'Genre', COUNT(h.history_id) AS 'Peminat' 
                               FROM History h JOIN Movies m ON h.movie_id = m.movie_id 
                               JOIN Genres g ON m.genre_id = g.genre_id 
                               GROUP BY g.nama_genre", dgvDemografiGenre, conn);
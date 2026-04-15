using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_History : UserControl
    {
        public UC_History()
        {
            InitializeComponent();
            btnDeleteHistory.Click += btnDeleteHistory_Click;
        }

        private void UC_History_Load(object sender, EventArgs e)
        {
            LoadDataHistory();
        }

        private void LoadDataHistory()
        {
            if (SesiUser.IdUser == 0) return;

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT h.history_id, m.judul AS 'Judul Film', h.tanggal_nonton AS 'Waktu Menonton'
                                     FROM History h
                                     JOIN Movies m ON h.movie_id = m.movie_id
                                     WHERE h.user_id = @uid
                                     ORDER BY h.tanggal_nonton DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHistory.DataSource = dt;

                        if (dgvHistory.Columns["history_id"] != null)
                        {
                            dgvHistory.Columns["history_id"].Visible = false;
                        }

                        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat history: " + ex.Message, "Error Database");
                }
            }
        }
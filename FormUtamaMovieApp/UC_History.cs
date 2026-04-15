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

        private void btnDeleteHistory_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count > 0)
            {
                int idHistoryTerpilih = Convert.ToInt32(dgvHistory.SelectedRows[0].Cells["history_id"].Value);

                DialogResult dialog = MessageBox.Show("Yakin ingin menghapus film ini dari riwayat tontonan?", "Hapus History", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    using (SqlConnection conn = KoneksiDB.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM History WHERE history_id = @hid";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@hid", idHistoryTerpilih);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Riwayat tontonan berhasil dihapus!", "Sukses");
                            LoadDataHistory();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan klik salah satu film di tabel terlebih dahulu sebelum menghapus.", "Pilih Data");
            }
        }
    }
}
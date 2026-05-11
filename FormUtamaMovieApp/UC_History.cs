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
                    // Poin 2: Menggunakan VIEW vwHistory
                    string query = "SELECT * FROM vwHistory WHERE user_id = @uid ORDER BY [Waktu Menonton] DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHistory.DataSource = dt;

                        // Sembunyikan kolom ID dan User ID
                        if (dgvHistory.Columns["history_id"] != null) dgvHistory.Columns["history_id"].Visible = false;
                        if (dgvHistory.Columns["user_id"] != null) dgvHistory.Columns["user_id"].Visible = false;

                        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat history: " + ex.Message);
                }
            }
        }

        private void btnDeleteHistory_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow != null)
            {
                int idHistoryTerpilih = Convert.ToInt32(dgvHistory.CurrentRow.Cells["history_id"].Value);

                DialogResult dialog = MessageBox.Show("Yakin ingin menghapus film ini dari riwayat tontonan?", "Hapus History", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    using (SqlConnection conn = KoneksiDB.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("sp_DeleteHistory", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@hid", idHistoryTerpilih);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Riwayat tontonan berhasil dihapus!", "Sukses");
                            LoadDataHistory();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menghapus: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data di tabel terlebih dahulu.");
            }
        }
    }
}
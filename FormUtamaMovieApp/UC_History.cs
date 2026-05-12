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
            this.vwHistoryTableAdapter.Fill(this.movieDBDataSet.vwHistory);
            vwHistoryBindingSource.Filter = "user_id = " + SesiUser.IdUser;
            btnDeleteHistory.Click += btnDeleteHistory_Click;
        }
        /*
        private void UC_History_Load(object sender, EventArgs e)
        {
            LoadDataHistory();
        }
        */

        private void LoadDataHistory()
        {
            if (SesiUser.IdUser == 0) return;

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vwHistory WHERE user_id = @uid ORDER BY [Waktu Menonton] DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHistory.DataSource = dt;


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
            if (vwHistoryBindingSource.Current != null)
            {
                var dataSekarang = (System.Data.DataRowView)vwHistoryBindingSource.Current;

                int idHistoryTerpilih = Convert.ToInt32(dataSekarang["history_id"]);

                DialogResult dialog = MessageBox.Show("Yakin ingin menghapus film ini dari riwayat tontonan?",
                    "Hapus History", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

                            this.vwHistoryTableAdapter.Fill(this.movieDBDataSet.vwHistory);

                            MessageBox.Show("Riwayat tontonan berhasil dihapus!", "Sukses");
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
                MessageBox.Show("Riwayat masih kosong atau belum terpilih.");
            }
        }
    }
}
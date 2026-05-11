using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_Review : UserControl
    {
        public UC_Review()
        {
            InitializeComponent();

            btnUpdateComment.Click += btnUpdate_Click;
            btnDeleteComment.Click += btnDelete_Click;

            LoadDataReview();
        }

        public void LoadDataReview()
        {
            if (SesiUser.IdUser == 0) return;

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM vwReview WHERE user_id = @uid ORDER BY Tanggal DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvComment.DataSource = dt;

                        if (dgvComment.Columns["review_id"] != null) dgvComment.Columns["review_id"].Visible = false;
                        if (dgvComment.Columns["user_id"] != null) dgvComment.Columns["user_id"].Visible = false;

                        dgvComment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Gagal memuat: " + ex.Message); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvComment.CurrentRow != null)
            {
                int idReview = Convert.ToInt32(dgvComment.CurrentRow.Cells["review_id"].Value);
                int skorBaru = Convert.ToInt32(dgvComment.CurrentRow.Cells["Rating"].Value);
                string komenBaru = dgvComment.CurrentRow.Cells["Ulasan / Komentar"].Value.ToString();

                using (SqlConnection conn = KoneksiDB.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_UpdateReview", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", idReview);
                            cmd.Parameters.AddWithValue("@skor", skorBaru);
                            cmd.Parameters.AddWithValue("@komen", komenBaru);

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Ulasan berhasil diperbarui!", "Update Berhasil");
                        LoadDataReview();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Kesalahan Database: " + ex.Message, "Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal update: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvComment.CurrentRow != null)
            {
                int idReview = Convert.ToInt32(dgvComment.CurrentRow.Cells["review_id"].Value);
                string judul = dgvComment.CurrentRow.Cells["Judul Film"].Value.ToString();

                DialogResult konfirmasi = MessageBox.Show($"Yakin mau hapus ulasan film {judul}?",
                    "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    using (SqlConnection conn = KoneksiDB.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Reviews WHERE review_id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", idReview);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Ulasan terhapus.");
                            LoadDataReview();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal hapus: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
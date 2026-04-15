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
                    string query = @"
                        SELECT 
                            r.review_id, 
                            m.judul AS 'Judul Film', 
                            r.skor_rating AS 'Rating', 
                            r.komentar AS 'Ulasan / Komentar', 
                            r.tanggal_diposting AS 'Tanggal' 
                        FROM Reviews r
                        INNER JOIN Movies m ON r.movie_id = m.movie_id
                        WHERE r.user_id = @uid
                        ORDER BY r.tanggal_diposting DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvComment.DataSource = dt;

                        if (dgvComment.Columns["review_id"] != null)
                            dgvComment.Columns["review_id"].Visible = false;

                        dgvComment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvComment.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dgvComment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat: " + ex.Message);
                }
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
                        string query = "UPDATE Reviews SET skor_rating = @skor, komentar = @komen WHERE review_id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@skor", skorBaru);
                            cmd.Parameters.AddWithValue("@komen", komenBaru);
                            cmd.Parameters.AddWithValue("@id", idReview);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Ulasan berhasil diperbarui!", "Update Berhasil");
                        LoadDataReview();
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
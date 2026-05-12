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

            try 
            {
                this.vwReviewTableAdapter.Fill(this.movieDBDataSet.vwReview);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message); 
            }
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
                var dataSekarang = (System.Data.DataRowView)vwReviewBindingSource.Current;
                int idReview = Convert.ToInt32(dataSekarang["review_id"]);

                int skorBaru = (int)numRating.Value;
                string komenBaru = txtKomentar.Text;

                if (string.IsNullOrWhiteSpace(komenBaru))
                {
                    MessageBox.Show("Komentar tidak boleh kosong!");
                    return;
                }

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
                            this.vwReviewTableAdapter.Fill(this.movieDBDataSet.vwReview);
                        }
                        MessageBox.Show("Ulasan berhasil diperbarui!", "Sukses");

                        //LoadDataReview();
                        //txtKomentar.Clear();
                        //numRating.Value = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal update: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih ulasan yang ingin diubah dari tabel terlebih dahulu.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (vwReviewBindingSource.Current != null)
            {
                var dataSekarang = (System.Data.DataRowView)vwReviewBindingSource.Current;

                int idReview = Convert.ToInt32(dataSekarang["review_id"]);
                string judul = dataSekarang["Judul Film"].ToString();

                DialogResult konfirmasi = MessageBox.Show("Yakin mau hapus ulasan film " + judul + "?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    using (SqlConnection conn = KoneksiDB.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("sp_DeleteReview", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", idReview);

                                cmd.ExecuteNonQuery();

                                this.vwReviewTableAdapter.Fill(this.movieDBDataSet.vwReview);
                            }
                            MessageBox.Show("Ulasan berhasil terhapus.", "Sukses");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Gagal hapus: " + ex.Message, "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih ulasan yang ingin dihapus terlebih dahulu.");
            }
        }

        private void dgvComment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
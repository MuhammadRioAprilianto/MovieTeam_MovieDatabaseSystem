using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class FormIsiReview : Form
    {
        private int idMoviePilihan;

        public FormIsiReview(int id, string judul)
        {
            InitializeComponent();
            this.idMoviePilihan = id;
            lblJudulFilm.Text = "Memberi ulasan untuk: " + judul;

            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (SesiUser.IdUser == 0)
            {
                MessageBox.Show("Sesi berakhir, silakan login ulang.");
                this.Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKomentar.Text))
            {
                MessageBox.Show("Silakan isi komentar kamu terlebih dahulu.");
                return;
            }

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertReview", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@uid", SesiUser.IdUser);
                        cmd.Parameters.AddWithValue("@mid", this.idMoviePilihan);
                        cmd.Parameters.AddWithValue("@skor", (int)numRating.Value);
                        cmd.Parameters.AddWithValue("@komen", txtKomentar.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Review kamu berhasil disimpan!", "Sukses");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Gagal menyimpan: " + ex.Message, "Pesan Database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan review: " + ex.Message);
                }
            }
        }

        private void FormIsiReview_Load(object sender, EventArgs e)
        {
        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


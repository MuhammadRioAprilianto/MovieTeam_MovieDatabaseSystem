using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_MovieCardAdmin : UserControl
    {
        private int _movieId;
        private string _judul;

        public UC_MovieCardAdmin()
        {
            InitializeComponent();
        }

        public void SetData(int id, string judul)
        {
            _movieId = id;
            _judul = judul;
            lblJudulMovie.Text = judul;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormDialogMovie frm = new FormDialogMovie(_movieId);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (this.ParentForm is FormUtama mainForm)
                {
                    mainForm.TampilkanHalaman(new UC_ManageMovie());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Yakin ingin menghapus film '{_judul}'?",
                              "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = KoneksiDB.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Movies SET is_deleted = 1 WHERE movie_id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", _movieId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film berhasil dihapus dari katalog.");

                            this.Parent.Controls.Remove(this);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus: " + ex.Message);
                    }
                }
            }
        }
    }
}
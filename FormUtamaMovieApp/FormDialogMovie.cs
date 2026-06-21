using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using ExcelDataReader;

namespace FormUtamaMovieApp
{
    public partial class FormDialogMovie : Form
    {
        private int? _movieId;
        private bool isEdit => _movieId.HasValue;

        private byte[] ConvertImageToByteArray(Image img)
        {
            if (img == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Simpan gambar ke dalam memory stream
                img.Save(ms, img.RawFormat);
                return ms.ToArray(); // Ubah jadi array byte
            }
        }

        public FormDialogMovie(int? id = null)
        {
            InitializeComponent();
            _movieId = id;
            this.Load += FormDialogMovie_Load;
        }

        private void FormDialogMovie_Load(object sender, EventArgs e)
        {
            LoadGenreToComboBox();

            if (isEdit)
            {
                this.Text = "Edit Movie";
                btnSave.Text = "Update";
                LoadExistingData();

                btnPilihFileExcel.Visible = false;
                btnImportExcel.Visible = false;
                txtPathExcel.Visible = false;
                lblInfoImport.Visible = false;
            }
            else
            {
                this.Text = "Add Movie";
                btnSave.Text = "Save";

                btnPilihFileExcel.Visible = true;
                btnImportExcel.Visible = true;
                txtPathExcel.Visible = true;

                lblInfoImport.Visible = true;
            }
        }

        private void LoadGenreToComboBox()
        {
            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT genre_id, nama_genre FROM Genres", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbGenre.DataSource = dt;
                cbGenre.DisplayMember = "nama_genre";
                cbGenre.ValueMember = "genre_id";
            }
        }

        private void LoadExistingData()
        {
            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Movies WHERE movie_id = @id", conn);
                cmd.Parameters.AddWithValue("@id", _movieId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtJudul.Text = dr["judul"].ToString();
                    cbGenre.SelectedValue = dr["genre_id"];
                    numDurasi.Value = Convert.ToInt32(dr["durasi"]);
                    txtDeskripsi.Text = dr["deskripsi"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();

                    string spName = isEdit ? "sp_UpdateMovie" : "sp_InsertMovie";

                    using (SqlCommand cmd = new SqlCommand(spName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@j", txtJudul.Text);
                        cmd.Parameters.AddWithValue("@g", cbGenre.SelectedValue);
                        cmd.Parameters.AddWithValue("@dur", numDurasi.Value);
                        cmd.Parameters.AddWithValue("@d", txtDeskripsi.Text);

                        byte[] posterBiner = ConvertImageToByteArray(pbPoster.Image);

                        if (posterBiner != null)
                        {
                            cmd.Parameters.AddWithValue("@poster", posterBiner);
                        }
                        else
                        {
                            cmd.Parameters.Add("@poster", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                        if (isEdit)
                        {
                            cmd.Parameters.AddWithValue("@id", _movieId);
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan!", "Sukses");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numDurasi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbPoster.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Document|*.xls;*.xlsx";
            ofd.Title = "Pilih File Excel Data Film";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPathExcel.Text = ofd.FileName;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            string pathExcel = txtPathExcel.Text.Trim();

            if (string.IsNullOrEmpty(pathExcel) || !File.Exists(pathExcel))
            {
                MessageBox.Show("Silakan pilih file Excel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var stream = File.Open(pathExcel, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                        });

                        DataTable dt = result.Tables[0];

                        using (SqlConnection conn = KoneksiDB.GetConnection())
                        {
                            conn.Open();

                            foreach (DataRow row in dt.Rows)
                            {
                                if (string.IsNullOrWhiteSpace(row["judul"].ToString())) continue;

                                using (SqlCommand cmd = new SqlCommand("sp_InsertMovie", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@j", row["judul"].ToString());
                                    cmd.Parameters.AddWithValue("@g", Convert.ToInt32(row["genre_id"]));
                                    cmd.Parameters.AddWithValue("@dur", Convert.ToInt32(row["durasi"]));
                                    cmd.Parameters.AddWithValue("@d", row["deskripsi"].ToString());

                                    string pathLengkapGambar = row["path_poster"].ToString();

                                    if (!string.IsNullOrEmpty(pathLengkapGambar) && File.Exists(pathLengkapGambar))
                                    {
                                        using (Image img = Image.FromFile(pathLengkapGambar))
                                        {
                                            byte[] posterBiner = ConvertImageToByteArray(img);
                                            cmd.Parameters.AddWithValue("@poster", posterBiner);
                                        }
                                    }
                                    else
                                    {
                                        cmd.Parameters.Add("@poster", SqlDbType.VarBinary).Value = DBNull.Value;
                                    }

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Data film dari Excel berhasil diimpor beserta posternya!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengimpor data. Pastikan file Excel sedang tidak dibuka oleh aplikasi lain.\n\nDetail: " + ex.Message, "Error Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
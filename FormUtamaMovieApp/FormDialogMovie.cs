using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class FormDialogMovie : Form
    {
        private int? _movieId;
        private bool isEdit => _movieId.HasValue;

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
            }
            else
            {
                this.Text = "Add Movie";
                btnSave.Text = "Save";
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
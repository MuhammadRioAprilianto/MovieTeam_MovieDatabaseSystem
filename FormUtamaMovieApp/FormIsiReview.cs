using System;
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


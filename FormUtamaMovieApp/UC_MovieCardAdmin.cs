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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            panelSidebar.Visible = false;
            TampilkanHalaman(new UC_KatalogMovie());
        }

        public void TampilkanHalaman(UserControl halamanBaru)
        {
            panelContent.Controls.Clear();
            halamanBaru.Dock = DockStyle.Fill;
            panelContent.Controls.Add(halamanBaru);
            halamanBaru.BringToFront();
        }

        private void btnReview_Click(object sender, EventArgs e) => TampilkanHalaman(new UC_Review());
        private void btnHistory_Click(object sender, EventArgs e) => TampilkanHalaman(new UC_History());
    }
}
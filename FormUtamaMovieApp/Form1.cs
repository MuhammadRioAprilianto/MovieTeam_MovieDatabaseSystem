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

        private void AturMenuBerdasarkanRole()
        {
            if (SesiUser.RoleId == 1)
            {
                btnKatalog.Text = "Manage Movie";
                btnWatchlist.Text = "Dashboard";

                btnReview.Visible = false;
                btnHistory.Visible = false;

                btnKatalog.BackColor = Color.FromArgb(255, 255, 0);
                btnWatchlist.BackColor = Color.FromArgb(255, 255, 0);
            }
            else
            {
                btnKatalog.Text = "Movie Catalog";
                btnWatchlist.Text = "Watchlist";
                btnReview.Visible = true;
                btnHistory.Visible = true;

                btnKatalog.BackColor = Color.Yellow;
                btnWatchlist.BackColor = Color.Yellow;
            }
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            FormLogin popUpLogin = new FormLogin();

            if (popUpLogin.ShowDialog() == DialogResult.OK)
            {
                btnLoginRegister.Visible = false;
                panelSidebar.Visible = true;

                AturMenuBerdasarkanRole();

                if (SesiUser.RoleId == 1)
                {
                    TampilkanHalaman(new UC_ManageMovie());
                }
                else
                {
                    TampilkanHalaman(new UC_KatalogMovie());
                }
            }
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            if (SesiUser.RoleId == 1)
            {
                TampilkanHalaman(new UC_ManageMovie());
            }
            else
            {
                TampilkanHalaman(new UC_KatalogMovie());
            }
        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            if (SesiUser.RoleId == 1)
            {
                TampilkanHalaman(new UC_AdminDashboard());
            }
            else
            {
                TampilkanHalaman(new UC_Watchlist());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SesiUser.IdUser = 0;
            SesiUser.Nama = "";
            SesiUser.RoleId = 0;

            panelSidebar.Visible = false;
            btnLoginRegister.Visible = true;
            TampilkanHalaman(new UC_KatalogMovie());

            MessageBox.Show("Anda telah logout.");
        }

        private void btnReview_Click(object sender, EventArgs e) => TampilkanHalaman(new UC_Review());
        private void btnHistory_Click(object sender, EventArgs e) => TampilkanHalaman(new UC_History());
    }
}
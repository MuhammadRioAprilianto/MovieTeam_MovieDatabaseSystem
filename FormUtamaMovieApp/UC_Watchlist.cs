using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class UC_Watchlist : UserControl
    {
        public UC_Watchlist()
        {
            InitializeComponent();
            LoadDataWatchlist();
        }

        public void LoadDataWatchlist()
        {
            flpWatchlist.Controls.Clear();

            if (SesiUser.IdUser == 0)
            {
                Label lblPesan = new Label();
                lblPesan.Text = "Silakan login untuk melihat Watchlist Anda.";
                lblPesan.AutoSize = true;
                lblPesan.ForeColor = System.Drawing.Color.White;
                flpWatchlist.Controls.Add(lblPesan);
                return;
            }
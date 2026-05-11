using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormUtamaMovieApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            txtPasswordLogin.UseSystemPasswordChar = true;
            txtPasswordRegis.UseSystemPasswordChar = true;

            panelLogin.Visible = true;
            panel1.Visible = false;

            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            RegisterToLogin.LinkClicked += RegisterToLogin_LinkClicked;
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panelLogin.Visible = false;
        }

        private void RegisterToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = true;
            panel1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsernameLogin.Text) || string.IsNullOrWhiteSpace(txtPasswordLogin.Text))
            {
                MessageBox.Show("username tidak boleh dikosongi!", "Peringatan");
                return;
            }

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LoginAccount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user", txtUsernameLogin.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPasswordLogin.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SesiUser.IdUser = Convert.ToInt32(reader["id"]);
                                SesiUser.Nama = reader["nama"].ToString();
                                SesiUser.RoleId = Convert.ToInt32(reader["role_id"]);

                                MessageBox.Show("Login Berhasil! Halo, " + SesiUser.Nama, "Sukses");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Gagal Login");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaRegis.Text) || string.IsNullOrWhiteSpace(txtUserRegis.Text) || string.IsNullOrWhiteSpace(txtPasswordRegis.Text)) return;

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_RegisterAccount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nama", txtNamaRegis.Text);
                        cmd.Parameters.AddWithValue("@user", txtUserRegis.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPasswordRegis.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Akun berhasil dibuat! Silakan Login.", "Sukses");

                        panelLogin.Visible = true;
                        panel1.Visible = false;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Gagal Daftar");
                }
            }
        }
    }
}
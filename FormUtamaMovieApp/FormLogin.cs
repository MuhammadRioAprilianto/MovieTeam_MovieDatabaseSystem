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
                MessageBox.Show("Isi dulu bos, jangan dikosongin!", "Peringatan");
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
                    MessageBox.Show(ex.Message, "Gagal Login"); // Pesan dari RAISERROR
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaRegis.Text) || string.IsNullOrWhiteSpace(txtUserRegis.Text) || string.IsNullOrWhiteSpace(txtPasswordRegis.Text))
            {
                MessageBox.Show("Semua kolom (Nama, Username, Password) wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = KoneksiDB.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Accounts (role_id, username, password, nama) VALUES (2, @user, @pass, @nama)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNamaRegis.Text);
                        cmd.Parameters.AddWithValue("@user", txtUserRegis.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPasswordRegis.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Akun berhasil dibuat! Silakan Login.", "Sukses");

                        txtNamaRegis.Clear();
                        txtUserRegis.Clear();
                        txtPasswordRegis.Clear();

                        panelLogin.Visible = true;
                        panel1.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate key"))
                    {
                        MessageBox.Show("Username tersebut sudah digunakan.", "Gagal Daftar");
                    }
                    else
                    {
                        MessageBox.Show("Gagal Daftar: " + ex.Message);
                    }
                }
            }
        }
    }
}
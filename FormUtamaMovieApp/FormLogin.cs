using System;
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
namespace FormUtamaMovieApp
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkToRegister = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.txtNamaRegis = new System.Windows.Forms.TextBox();
            this.RegisterToLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelPasswordRegis = new System.Windows.Forms.Label();
            this.labelUsernameRegis = new System.Windows.Forms.Label();
            this.txtPasswordRegis = new System.Windows.Forms.TextBox();
            this.txtUserRegis = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.linkToRegister);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.txtPasswordLogin);
            this.panelLogin.Controls.Add(this.txtUsernameLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(800, 450);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.txtNamaRegis);
            this.panel1.Controls.Add(this.RegisterToLogin);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.labelPasswordRegis);
            this.panel1.Controls.Add(this.labelUsernameRegis);
            this.panel1.Controls.Add(this.txtPasswordRegis);
            this.panel1.Controls.Add(this.txtUserRegis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // linkToRegister
            // 
            this.linkToRegister.AutoSize = true;
            this.linkToRegister.Location = new System.Drawing.Point(346, 262);
            this.linkToRegister.Name = "linkToRegister";
            this.linkToRegister.Size = new System.Drawing.Size(159, 20);
            this.linkToRegister.TabIndex = 5;
            this.linkToRegister.TabStop = true;
            this.linkToRegister.Text = "belum memiliki akun?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Yellow;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogin.Location = new System.Drawing.Point(356, 222);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(136, 36);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(224, 175);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(224, 140);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(324, 169);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(255, 26);
            this.txtPasswordLogin.TabIndex = 1;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(324, 137);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(255, 26);
            this.txtUsernameLogin.TabIndex = 0;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(222, 143);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(51, 20);
            this.labelNama.TabIndex = 21;
            this.labelNama.Text = "Nama";
            // 
            // txtNamaRegis
            // 
            this.txtNamaRegis.Location = new System.Drawing.Point(323, 137);
            this.txtNamaRegis.Name = "txtNamaRegis";
            this.txtNamaRegis.Size = new System.Drawing.Size(255, 26);
            this.txtNamaRegis.TabIndex = 20;
            this.txtNamaRegis.TextChanged += new System.EventHandler(this.txtNamaRegis_TextChanged);
            // 
            // RegisterToLogin
            // 
            this.RegisterToLogin.AutoSize = true;
            this.RegisterToLogin.Location = new System.Drawing.Point(344, 294);
            this.RegisterToLogin.Name = "RegisterToLogin";
            this.RegisterToLogin.Size = new System.Drawing.Size(160, 20);
            this.RegisterToLogin.TabIndex = 19;
            this.RegisterToLogin.TabStop = true;
            this.RegisterToLogin.Text = "sudah memiliki akun?";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Yellow;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.Location = new System.Drawing.Point(354, 254);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 36);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelPasswordRegis
            // 
            this.labelPasswordRegis.AutoSize = true;
            this.labelPasswordRegis.Location = new System.Drawing.Point(222, 207);
            this.labelPasswordRegis.Name = "labelPasswordRegis";
            this.labelPasswordRegis.Size = new System.Drawing.Size(78, 20);
            this.labelPasswordRegis.TabIndex = 17;
            this.labelPasswordRegis.Text = "Password";
            // 
            // labelUsernameRegis
            // 
            this.labelUsernameRegis.AutoSize = true;
            this.labelUsernameRegis.Location = new System.Drawing.Point(222, 172);
            this.labelUsernameRegis.Name = "labelUsernameRegis";
            this.labelUsernameRegis.Size = new System.Drawing.Size(83, 20);
            this.labelUsernameRegis.TabIndex = 16;
            this.labelUsernameRegis.Text = "Username";
            // 
            // txtPasswordRegis
            // 
            this.txtPasswordRegis.Location = new System.Drawing.Point(322, 201);
            this.txtPasswordRegis.Name = "txtPasswordRegis";
            this.txtPasswordRegis.Size = new System.Drawing.Size(255, 26);
            this.txtPasswordRegis.TabIndex = 15;
            // 
            // txtUserRegis
            // 
            this.txtUserRegis.Location = new System.Drawing.Point(322, 169);
            this.txtUserRegis.Name = "txtUserRegis";
            this.txtUserRegis.Size = new System.Drawing.Size(255, 26);
            this.txtUserRegis.TabIndex = 14;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Page";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.LinkLabel linkToRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox txtNamaRegis;
        private System.Windows.Forms.LinkLabel RegisterToLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelPasswordRegis;
        private System.Windows.Forms.Label labelUsernameRegis;
        private System.Windows.Forms.TextBox txtPasswordRegis;
        private System.Windows.Forms.TextBox txtUserRegis;
    }
}
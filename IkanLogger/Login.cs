using IkanLogger.Models;
using IkanLogger.Services;
using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IkanLogger
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtUserName.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtPassword.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            linkSignUp.LinkColor = ColorTranslator.FromHtml("#1F4F6E");
            btnLogin.BackColor = ColorTranslator.FromHtml("#1F4F6E");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#EBFFFF");

            //btnLogin.FlatStyle = FlatStyle.Flat;
            //btnLogin.FlatAppearance.BorderSize = 0;
            //btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            //btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //btnLogin.UseVisualStyleBackColor = false;

            // Hubungkan event handler
            btnLogin.MouseEnter += BtnLogin_MouseEnter;
            btnLogin.MouseLeave += BtnLogin_MouseLeave;
        }
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = ColorTranslator.FromHtml("#8BD8F0");
            btnLogin.Cursor = Cursors.Hand;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            btnLogin.Cursor = Cursors.Default;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username dan password tidak boleh kosong!");
                    return;
                }

                int userId = await UserService.LoginAsync(username, password);

                if (userId > 0)
                {
                    MessageBox.Show("Login berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka dashboard
                    Dashboard dashboard = new Dashboard(userId);
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!",
                                    "Login Gagal",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}

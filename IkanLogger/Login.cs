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

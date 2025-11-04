using IkanLogger.Models;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User(tbUsername.Text, tbPassword.Text);

                if (u.Login(tbUsername.Text, tbPassword.Text))
                {
                    MessageBox.Show("Login berhasil", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbPassword.Clear();
                    tbUsername.Clear();

                    Dashboard d = new Dashboard(u);
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

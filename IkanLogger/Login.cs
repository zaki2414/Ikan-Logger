using System;
using System.Windows.Forms;
using System.Drawing;
using IkanLogger.Models;

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
            User u = new User(tbUsername.Text, tbPassword.Text);

            if (u.Login(u.userName, u.userPassword))
            {
                MessageBox.Show("Login Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

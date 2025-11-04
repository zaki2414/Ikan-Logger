using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IkanLogger.Models;

namespace IkanLogger
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbUsername.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User u = new User(tbUsername.Text, tbPassword.Text);

                if (u.Register(tbUsername.Text, tbEmail.Text, tbPassword.Text))
                {
                    MessageBox.Show("Berhasil membuat akun", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbPassword.Clear();
                    tbUsername.Clear();
                    tbEmail.Clear();

                    Login l = new Login();
                    l.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi gagal!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: "+ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

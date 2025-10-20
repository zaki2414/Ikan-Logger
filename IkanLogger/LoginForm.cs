using System;
using System.Windows.Forms;
using System.Drawing; 

namespace IkanLogger
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = new User(tbUsername.Text, tbPassword.Text);

            if (u.Login(u.UserName, u.Password)){
                MessageBox.Show("Login Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("Login Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

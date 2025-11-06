 using IkanLogger.Services;

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

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbUsername.Text) ||
                    string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = await UserService.RegisterAsync(tbUsername.Text, tbPassword.Text);

                if (success)
                {
                    MessageBox.Show("Berhasil membuat akun!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi gagal!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

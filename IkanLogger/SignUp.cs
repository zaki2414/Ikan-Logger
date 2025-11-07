 using IkanLogger.Services;
using System.Drawing.Drawing2D;

namespace IkanLogger
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            txtSignUp.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtUsername.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtPassword.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtAlready.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            linkLogin.LinkColor = ColorTranslator.FromHtml("#1F4F6E");
            linkLogin.ActiveLinkColor = ColorTranslator.FromHtml("#8BD8F0");

            tbUsername.BackColor = ColorTranslator.FromHtml("#D8F4FB");
            tbPassword.BackColor = ColorTranslator.FromHtml("#D8F4FB");

            btnSignUp.BackColor = ColorTranslator.FromHtml("#D8F4FB");
            btnSignUp.ForeColor = ColorTranslator.FromHtml("#EBFFFF");
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 0;

            // Hubungkan event handler
            btnSignUp.MouseEnter += BtnSignUp_MouseEnter;
            btnSignUp.MouseLeave += BtnSignUp_MouseLeave;
            btnSignUp.Paint += BtnSignUp_Paint;
            tbUsername.TextChanged += TbUsername_TextChanged;
            tbPassword.TextChanged += TbPassword_TextChanged;
        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            tbUsername.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
        }

        private void BtnSignUp_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Tentukan warna & radius
            int radius = 20; // ubah sesuai selera
            Color fillColor = ColorTranslator.FromHtml("#1F4F6E");

            // Buat path dengan rounded corner
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
                int diameter = radius * 2;
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                // Isi warna latar belakang
                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Gambar teks di tengah
                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    rect,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void BtnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.ForeColor = ColorTranslator.FromHtml("#8BD8F0");
            btnSignUp.Cursor = Cursors.Hand;
        }

        private void BtnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.ForeColor = ColorTranslator.FromHtml("#D8F4FB");
            btnSignUp.Cursor = Cursors.Default;
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
                    CustomMessageBox msg = new CustomMessageBox("Semua field harus diisi!", MessageBoxIcon.Information);
                    msg.ShowDialog();
                    return;
                }

                bool success = await UserService.RegisterAsync(tbUsername.Text, tbPassword.Text);

                if (success)
                {
                    CustomMessageBox msg = new CustomMessageBox("Sukses! Berhasil membuat akun!", MessageBoxIcon.Information);
                    msg.ShowDialog();

                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    CustomMessageBox msg = new CustomMessageBox("Maaf, Registrasi gagal!", MessageBoxIcon.Information);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox msg = new CustomMessageBox("Error: " + ex.Message, MessageBoxIcon.Information);
                msg.ShowDialog();
            }
        }
    }
}

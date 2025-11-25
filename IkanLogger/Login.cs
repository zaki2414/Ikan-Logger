using IkanLogger.Models;
using IkanLogger.Services;
using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
            linkSignUp.ActiveLinkColor = ColorTranslator.FromHtml("#8BD8F0");

            tbUsername.BackColor = ColorTranslator.FromHtml("#D8F4FB");
            tbPassword.BackColor = ColorTranslator.FromHtml("#D8F4FB");

            btnLogin.BackColor = ColorTranslator.FromHtml("#D8F4FB");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#EBFFFF");
        }
        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            tbUsername.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
        }

        private void BtnLogin_Paint(object sender, PaintEventArgs e)
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

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = ColorTranslator.FromHtml("#8BD8F0");
            btnLogin.Cursor = Cursors.Hand;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = ColorTranslator.FromHtml("#D8F4FB");
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
                    CustomMessageBox msg = new CustomMessageBox("Username dan password tidak boleh kosong!", MessageBoxIcon.Information);
                    msg.ShowDialog();
                    return;
                }

                int userId = await UserService.LoginAsync(username, password);

                if (userId > 0)
                {
                    CustomMessageBox msg = new CustomMessageBox("Login berhasil!", MessageBoxIcon.Information);
                    msg.ShowDialog();

                    // Buka dashboard
                    Dashboard dashboard = new Dashboard(userId);
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    CustomMessageBox msg = new CustomMessageBox("Username atau password salah!", MessageBoxIcon.Information);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox msg = new CustomMessageBox("Error: " + ex.Message, MessageBoxIcon.Information);
                msg.ShowDialog();
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

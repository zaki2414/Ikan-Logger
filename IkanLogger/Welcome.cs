using IkanLogger.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkanLogger
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            txtJudul.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtSubJudul.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtJunPro.ForeColor = ColorTranslator.FromHtml("#F8FCFC");

            txtJudul.Font = FontManager.Get("MAUIKEA_Demo.otf", 105);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}

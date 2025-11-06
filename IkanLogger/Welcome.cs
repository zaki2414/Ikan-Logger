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
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtSubJudul.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            txtJunPro.ForeColor = ColorTranslator.FromHtml("#F8FCFC");

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkanLogger
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, MessageBoxIcon iconType)
        {
            InitializeComponent();

            lblText.Text = message;

            // Warna khas aplikasi
            this.BackColor = ColorTranslator.FromHtml("#8BD8F0");
            lblText.ForeColor = ColorTranslator.FromHtml("#1F4F6E");
            btnOK.ForeColor = ColorTranslator.FromHtml("#1F4F6E");

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

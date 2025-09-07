using System;
using System.Windows.Forms;
using System.Drawing; // untuk Point

namespace IkanLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Buat button baru
            Button btn = new Button();
            btn.Text = "Klik Saya";
            btn.Size = new Size(100, 40);
            btn.Location = new Point(50, 50);

            // Tambahkan event handler
            btn.Click += (s, e) =>
            {
                MessageBox.Show("Halo, tombol ditekan!");
            };

            // Masukkan button ke form
            this.Controls.Add(btn);
        }
    }
}

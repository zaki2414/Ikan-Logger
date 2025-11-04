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
    public partial class Profile : Form
    {
        private User currentUser;
        public Profile(User user)
        {
            InitializeComponent();
            currentUser = user;

            currentUser.GetProfile(currentUser.Id);

            tbNama.Text = currentUser.UserName;
            tbEmail.Text = currentUser.Email;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.Show();
            this.Close();
        }
    }
}

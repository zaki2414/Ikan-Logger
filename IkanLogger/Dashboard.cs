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
    public partial class Dashboard : Form
    {
        private User currentUser;
        private int userId;
        public Dashboard(int userId )
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this.userId);
            profile.Show();
            this.Hide();

            profile.FormClosed += (s, args) => this.Show();
        }
    }
}

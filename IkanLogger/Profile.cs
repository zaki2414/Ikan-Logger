using IkanLogger.Models;
using IkanLogger.Services;

namespace IkanLogger
{
    public partial class Profile : Form
    {
        private int userId;
        private User currentUser;

        public Profile(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private async void Profile_Load(object sender, EventArgs e)
        {
            await LoadProfileAsync();
        }

        private async Task LoadProfileAsync()
        {
            currentUser = await UserService.GetProfileAsync(userId);

            if (currentUser != null)
            {
                tbNama.Text = currentUser.Username;
            }
            else
            {
                MessageBox.Show("Gagal memuat data profil.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            dashboard.Show();
            this.Hide();

            dashboard.FormClosed += (s, args) => this.Close();
        }
    }
}

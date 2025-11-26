using GMap.NET.WindowsForms;
using IkanLogger.Controllers;
using IkanLogger.Models;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Windows.Forms;

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
    public partial class Dashboard : Form
    {
        private User currentUser;
        private int userId;

        private GMapControl gmap;
        public Dashboard(int userId)
        {
            InitializeComponent();
            InitializeMap();
            this.userId = userId;
        }

        private void InitializeMap()
        {
            gmap = new GMapControl
            {
                Dock = DockStyle.Fill,
                MinZoom = 10,
                MaxZoom = 20,
                Zoom = 15,
                MapProvider = GMapProviders.BingMap,
                Position = new PointLatLng(-6.200000, 106.816666), // Jakarta example
                ShowCenter = false
            };
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            Controls.Add(gmap);
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this.userId);
            profile.Show();
            this.Hide();

            profile.FormClosed += (s, args) => this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

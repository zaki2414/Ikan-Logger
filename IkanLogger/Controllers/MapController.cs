using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace IkanLogger.Controllers
{
    public class MapController
    {
        public GMapControl CreateMap(double latitude, double longitude)
        {
            var gmap = new GMapControl
            {
                Dock = DockStyle.Fill,
                MinZoom = 10,
                MaxZoom = 20,
                Zoom = 15,
                MapProvider = GMapProviders.BingMap,
                Position = new PointLatLng(latitude, longitude),
                ShowCenter = false
            };

            // Ensure that the global GMaps instance is properly configured
            GMapProvider.UserAgent = "FishingMapApp/1.0";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            return gmap;
        }

    }
}

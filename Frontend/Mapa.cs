using GMap.NET;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using System;

namespace Frontend
{
    public class Mapa : GMapControl
    {
        public Mapa()
        {
            MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            SetPositionByKeywords("Barcelos, Portugal");
            ShowCenter = false; // remove a cruz vermelha no centro do MapControl
            MinZoom = 10;
            Zoom = 15;
            MaxZoom = 20;
            CanDragMap = true;
            DragButton = MouseButtons.Left;
            AutoScroll = true;
            MouseWheelZoomEnabled = true;
        }

        public static implicit operator Mapa(GMarkerGoogle v)
        {
            throw new NotImplementedException();
        }
    }
}

using GMap.NET;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using System;

namespace Frontend
{
    public sealed class Mapa : GMapControl
    {
        public Mapa(string position)
        {
            MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            SetPositionByKeywords(position);
            ShowCenter = false; // remove a cruz vermelha no centro do MapControl
            MinZoom = 10;
            Zoom = 15;
            MaxZoom = 20;
            CanDragMap = true;
            DragButton = MouseButtons.Left;
            AutoScroll = true;
            MouseWheelZoomEnabled = true;
        }
    }
}

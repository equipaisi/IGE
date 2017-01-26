using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Windows.Forms;
using GooglePlaces;
using Location = GoogleMaps.Geocoding.Location;

namespace Frontend
{
    public partial class Habitação : Form
    {
        public Habitação()
        {
            InitializeComponent();
        }

        private void Habitação_Load(object sender, EventArgs e)
        {
            var local =
               new GoogleMaps.GoogleMaps().GetCoordinates(
                   $"{labelRua.Text}, {labelCodigoPostal.Text}, {labelLocalidade.Text}");
            var pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(local.lat, local.lng, 250);
            var markersOverlay = new GMapOverlay("markers");

            mapa.Overlays.Clear();
            foreach (var t in pontosDeInteresse)
            {
                var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(t.Latitude.ToString()), Convert.ToDouble(t.Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText =$"{t.Name} \n {Utils.FormatPontosDeInteresse(t.Types)}";
                markersOverlay.Markers.Add(marker);
                mapa.Overlays.Add(markersOverlay);
            }

            var _marker = new GMarkerGoogle(new PointLatLng(local.lat, local.lng), GMarkerGoogleType.red);
            _marker.ToolTipText = "Habitação";
            markersOverlay.Markers.Add(_marker);

            mapa.ZoomAndCenterMarkers(markersOverlay.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Proprietario {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Aluguer {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void mapa_DoubleClick(object sender, EventArgs e)
        {
            mapa.Zoom += 1;
        }
    }
}

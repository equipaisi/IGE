using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GooglePlaces;
using Location = GoogleMaps.Location;

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
            Location local =
               new GoogleMaps.GoogleMaps().GetCoordinates(
                   $"{labelRua.Text}, {labelCodigoPostal.Text}, {labelLocalidade.Text}");
            List<Place> pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(local.lat, local.lng, 250);
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            mapa.Overlays.Clear();
            foreach (Place t in pontosDeInteresse)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(t.Latitude.ToString()), Convert.ToDouble(t.Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText =
                    $"{t.Name} \n {FormatPontosDeInteresse(t.Types)}";
                markersOverlay.Markers.Add(marker);
                mapa.Overlays.Add(markersOverlay);
            }

            GMarkerGoogle _marker = new GMarkerGoogle(new PointLatLng(local.lat, local.lng), GMarkerGoogleType.red);
            _marker.ToolTipText = "Habitação";
            markersOverlay.Markers.Add(_marker);

            mapa.ZoomAndCenterMarkers(markersOverlay.Id);
        }

        private static string FormatPontosDeInteresse(IList<string> types)
        {
            types.Remove("point_of_interest");
            return $"Categoria: {types[0]}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proprietario prt = new Proprietario();
            prt.MdiParent = IGE.ActiveForm;
            prt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aluguer alug = new Aluguer();
            alug.MdiParent = IGE.ActiveForm;
            alug.Show();
        }
    }
}

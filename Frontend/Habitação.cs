using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GoogleMaps;
using Place = GooglePlaces.Place;

namespace Frontend
{
    public partial class Habitação : Form
    {
        private GMarkerGoogle marker;
        public Habitação()
        {
            InitializeComponent();
        }

        private void Habitação_Load(object sender, EventArgs e)        
        {
            
            Location local =
              new GoogleMaps.GoogleMaps().GetCoordinates(
                  $"{labelRua.Text}, {labelCodigoPostal.Text}, {labelLocalidade.Text}");
            PointLatLng position = new PointLatLng(local.lat, local.lng);
            List<Place> pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(local.lat, local.lng, 250);
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            for (int i = 0; i < pontosDeInteresse.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(pontosDeInteresse[i].Latitude.ToString()), Convert.ToDouble(pontosDeInteresse[i].Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText = string.Format("{0} \n {1}", pontosDeInteresse[i].Name, FormatPontosDeInteresse(pontosDeInteresse[i].Types));
                markersOverlay.Markers.Add(marker);
                mapa.Overlays.Add(markersOverlay);
            }

            marker = new GMarkerGoogle(new PointLatLng(local.lat,local.lng), GMarkerGoogleType.red);
            marker.ToolTipText = string.Format("Habitação");
            markersOverlay.Markers.Add(marker);

            mapa.ZoomAndCenterMarkers(markersOverlay.Id);
        }


        private string FormatPontosDeInteresse(List<string> types)
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

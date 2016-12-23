using System;
using System.Windows.Forms;
using Frontend.GoogleMapsService;
using Frontend.GooglePlacesService;

namespace Frontend
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var place = new GoogleMapsClient().GetPlace("Rua José António Cruz, 4715-343, Braga");
                Console.WriteLine($"Address=\"{place.FormattedAddress}\",Latitude={place.Latitude},Longitude={place.Longitude},PlaceId={place.PlaceId}");
                var places = new GooglePlacesClient().GetPointsOfInterest(place.Latitude, place.Longitude, 500);
                foreach (var e in places)
                {
                    Console.WriteLine($"Name={e.Name},Coord=({e.Latitude},{e.Longitude})");
                    Console.WriteLine($"PlaceId={e.PlaceId},Name={e.Name},Coord=({e.Latitude},{e.Longitude}),Types=[{string.Join(",", e.Types)}]");
                }
                Application.Run(new FormLogin());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

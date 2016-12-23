using System;
using System.Windows.Forms;
using Frontend.GoogleMapsService;

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
                Application.Run(new FormLogin());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

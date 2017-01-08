using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using GoogleMaps.DistanceMatrix;
using GoogleMaps.Geocoding;

namespace GoogleMaps
{
    public class GoogleMaps : IGoogleMaps
    {
        private const string GeocodeBaseUrl = "https://maps.googleapis.com/maps/api/geocode/json?address=";
        private const string MatrixBaseUrl = "https://maps.googleapis.com/maps/api/distancematrix/json?";
        private const string ApiKey = "AIzaSyBPFsCVlF0_aZE46Tqutha3GVrqclwx7s0";

        #region Public API

        /// <summary>
        /// Retorna as coordenadas de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        /// <returns>Latitude e longitude da localidade</returns>
        public Location GetCoordinates(string location)
        {
            // TODO: estamos a assumir que é o primeiro elemento
            Geocoding.RootObject root = Magic<Geocoding.RootObject>(GetCoordinatesUrl(location));
            if (root.status != "OK") return null; // TODO: throw new Custom Exception
            if (root.results.Count < 1) return null;
            return root.results[0].geometry.location;
        }

        /// <summary>
        /// Retorna o <see cref="Place"/> de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        public Place GetPlace(string location)
        {
            // TODO: estamos a assumir que é o primeiro elemento
            Geocoding.RootObject root = Magic<Geocoding.RootObject>(GetCoordinatesUrl(location));
            if (root.status != "OK") return null;
            if (root.results.Count < 1) return null;
            return new Place
            {
                Latitude = root.results[0].geometry.location.lat,
                Longitude = root.results[0].geometry.location.lng,
                FormattedAddress = root.results[0].formatted_address,
                PlaceId = root.results[0].place_id
            };
        }

        /// <summary>
        /// Calcula a distância entre <paramref name="origin"></paramref> e <paramref name="destination"></paramref> para um determinado modo de transporte <paramref name="mode"></paramref>,
        /// </summary>
        /// <param name="origin">Origem</param>
        /// <param name="destination">Destino</param>
        /// <param name="mode">Modo de transporte</param>
        /// <returns>Distância entre <paramref name="origin"></paramref> e <paramref name="destination"></paramref></returns>
        public int DistanceBetween(Location origin, Location destination, TravelMode mode)
        {
            string o = $"{Convert.ToDouble(origin.lat.ToString(CultureInfo.InvariantCulture))},{Convert.ToDouble(origin.lng.ToString(CultureInfo.InvariantCulture))}";
            string d = $"{Convert.ToDouble(destination.lat.ToString(CultureInfo.InvariantCulture))},{Convert.ToDouble(destination.lng.ToString(CultureInfo.InvariantCulture))}";

            string url = $"{MatrixBaseUrl}language=pt-PT&units=metric&origins={o}&destinations={d}&key={ApiKey}";

            DistanceMatrix.RootObject root = Magic<DistanceMatrix.RootObject>(url);
            if (root.status != "OK") return -1; // TODO: throw new Custom Exception
            if (root.rows.Count < 1) return -1;
            if (root.rows[0].elements.Count < 1) return -1;
            if (root.rows[0].elements[0].status != "OK") return -1;
            return root.rows[0].elements[0].distance.value;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Retorna o URL do pedido a realizar.
        /// </summary>
        /// <param name="location">Localidade</param>
        private static string GetCoordinatesUrl(string location) => GeocodeBaseUrl + WebUtility.UrlEncode(location) + "&key=" + ApiKey;

        private static T Magic<T>(string url)
            => (T)new DataContractJsonSerializer(typeof(T)).ReadObject(GetResponse(CreateRequest(url)));

        private static MemoryStream GetResponse(HttpWebRequest request)
        {
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // verificar erros na resposta
                if (response != null && response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(string.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));

                string result = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return new MemoryStream(Encoding.Unicode.GetBytes(result)) { Position = 0 };
            }
        }

        private static HttpWebRequest CreateRequest(string requestUrl) => WebRequest.Create(requestUrl) as HttpWebRequest;

        #endregion
    }
}
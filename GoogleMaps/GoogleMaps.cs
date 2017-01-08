using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace GoogleMaps
{
    public class GoogleMaps : IGoogleMaps
    {
        private const string BaseUrl = "https://maps.googleapis.com/maps/api/geocode/json?address=";
        private const string ApiKey = "AIzaSyBPFsCVlF0_aZE46Tqutha3GVrqclwx7s0";

        #region Public API

        /// <summary>
        /// Retorna as coordenadas de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        /// <returns>Latitude e longitude da localidade</returns>
        public  Location GetCoordinates(string location)
        {
            // TODO: estamos a assumir que é o primeiro elemento
            RootObject root = Magic<RootObject>(GetCoordinatesUrl(location));
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
            RootObject root = Magic<RootObject>(GetCoordinatesUrl(location));
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
        #endregion

        #region Private Methods

        /// <summary>
        /// Retorna o URL do pedido a realizar.
        /// </summary>
        /// <param name="location">Localidade</param>
        private static string GetCoordinatesUrl(string location) => BaseUrl + WebUtility.UrlEncode(location) + "&key=" + ApiKey;

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
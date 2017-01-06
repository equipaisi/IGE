using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace GoogleMaps
{
    public class GoogleMaps //: IGoogleMaps
    {
        private const string ApiKey = "AIzaSyBPFsCVlF0_aZE46Tqutha3GVrqclwx7s0";

        public GoogleMaps()
        {

        }

        #region Public API
        public Location GetCoordinates(string location)
        {
            // TODO: estamos a assumir que é o primeiro elemento
            RootObject root = Magic<RootObject>(GetCoordinatesUrl(location));
            if (root.status != "OK") return null; // TODO: throw new Custom Exception
            if (root.results.Count < 1) return null;
            return root.results[0].geometry.location;
        }

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

        public string GetCoordinatesUrl(string location)
            => "https://maps.googleapis.com/maps/api/geocode/json?address=" + WebUtility.UrlEncode(location) + "&key=" +
               ApiKey;

        #endregion

        #region Private Methods

        private static T Magic<T>(string url)
            => (T)new DataContractJsonSerializer(typeof(T)).ReadObject(GetResponse(CreateRequest(url)));

        public static MemoryStream GetResponse(HttpWebRequest request)
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

        public static HttpWebRequest CreateRequest(string requestUrl) => WebRequest.Create(requestUrl) as HttpWebRequest;

        #endregion
    }
}
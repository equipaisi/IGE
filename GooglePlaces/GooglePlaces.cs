using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;

namespace GooglePlaces
{
    public class GooglePlaces : IGooglePlaces
    {
        private const string ApiKey = "AIzaSyBPFsCVlF0_aZE46Tqutha3GVrqclwx7s0";

        #region Public API

        /// <summary>
        /// Retorna uma lista de pontos de interesse, resultado de um Nearby Search.
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="radius">Raio (em metros) a pesquisar</param>
        /// <returns>Lista de <see cref="Place"/></returns>
        public List<Place> GetPointsOfInterest(double latitude, double longitude, int radius)
        {
            if (radius <= 0 || radius > 50000)
                throw new ArgumentOutOfRangeException("Radius must be a positive integer between 1 an 50 000");
            string url = CreateRequestUrl(latitude, longitude, radius);
            RootObject root = Magic<RootObject>(url);
            if (root.status != "OK") return null; // TODO: throw new Custom Exception
            if (root.results.Count < 1) return null;

            return root.results.Select(result => new Place
            {
                Name = result.name,
                PlaceId = result.place_id,
                Latitude = result.geometry.location.lat,
                Longitude = result.geometry.location.lng,
                Types = result.types
            }).ToList();
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Retorna o URL para um Nearby Search. 
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="radius">Raio (em metros) da pesquisa</param>
        /// <returns></returns>
        public string CreateRequestUrl(double latitude, double longitude, int radius)
        {
            CultureInfo us = CultureInfo.CreateSpecificCulture("en-US");
            string baseUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";
            return $"{baseUrl}location={latitude.ToString(us)},{longitude.ToString(us)}&radius={radius}&key={ApiKey}";
        }

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
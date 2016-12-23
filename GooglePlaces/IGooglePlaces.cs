using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GooglePlaces
{
    [ServiceContract]
    public interface IGooglePlaces
    {
        /// <summary>
        /// Retorna uma lista de pontos de interesse, resultado de um Nearby Search.
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="radius">Raio (em metros) a pesquisar</param>
        /// <returns></returns>
        [OperationContract]
        List<Place> GetPointsOfInterest(double latitude, double longitude, int radius);
    }

    [DataContract]
    public class Place
    {
        [DataMember]
        public string PlaceId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public List<string> Types { get; set; }
    }

    [DataContract]
    public class Location
    {
        [DataMember]
        public double lat { get; set; }

        [DataMember]
        public double lng { get; set; }
    }

    [DataContract]
    public class Geometry
    {
        [DataMember]
        public Location location { get; set; }
    }

    [DataContract]
    public class OpeningHours
    {
        [DataMember]
        public bool open_now { get; set; }
    }

    [DataContract]
    public class Photo
    {
        [DataMember]
        public int height { get; set; }

        [DataMember]
        public List<object> html_attributions { get; set; }

        [DataMember]
        public string photo_reference { get; set; }

        [DataMember]
        public int width { get; set; }
    }

    [DataContract]
    public class AltId
    {
        [DataMember]
        public string place_id { get; set; }

        [DataMember]
        public string scope { get; set; }
    }

    [DataContract]
    public class Result
    {
        [DataMember]
        public Geometry geometry { get; set; }

        [DataMember]
        public string icon { get; set; }

        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public OpeningHours opening_hours { get; set; }

        [DataMember]
        public List<Photo> photos { get; set; }

        [DataMember]
        public string place_id { get; set; }

        [DataMember]
        public string scope { get; set; }

        [DataMember]
        public List<AltId> alt_ids { get; set; }

        [DataMember]
        public string reference { get; set; }

        [DataMember]
        public List<string> types { get; set; }

        [DataMember]
        public string vicinity { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public List<Result> results { get; set; }

        [DataMember]
        public string status { get; set; }
    }

}
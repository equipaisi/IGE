using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace GoogleMaps
{
    [ServiceContract]
    public interface IGoogleMaps
    {
        /// <summary>
        /// Retorna as coordenadas de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        /// <returns></returns>
        [OperationContract]
        Location GetCoordinates(string location);

        /// <summary>
        /// Retorna o <see cref="Place"/> de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        /// <returns></returns>
        [OperationContract]
        Place GetPlace(string location);
    }

    [DataContract]
    public class Place
    {
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public string FormattedAddress { get; set; }
        [DataMember]
        public string PlaceId { get; set; }
    }

    [DataContract]
    public class AddressComponent
    {
        [DataMember]
        public string long_name { get; set; }

        [DataMember]
        public string short_name { get; set; }

        [DataMember]
        public List<string> types { get; set; }
    }

    [DataContract]
    public class Northeast
    {
        [DataMember]
        public double lat { get; set; }

        [DataMember]
        public double lng { get; set; }
    }

    [DataContract]
    public class Southwest
    {
        [DataMember]
        public double lat { get; set; }

        [DataMember]
        public double lng { get; set; }
    }

    [DataContract]
    public class Bounds
    {
        [DataMember]
        public Northeast northeast { get; set; }

        [DataMember]
        public Southwest southwest { get; set; }
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
    public class Northeast2
    {
        [DataMember]
        public double lat { get; set; }

        [DataMember]
        public double lng { get; set; }
    }

    [DataContract]
    public class Southwest2
    {
        [DataMember]
        public double lat { get; set; }

        [DataMember]
        public double lng { get; set; }
    }

    [DataContract]
    public class Viewport
    {
        [DataMember]
        public Northeast2 northeast { get; set; }

        [DataMember]
        public Southwest2 southwest { get; set; }
    }

    [DataContract]
    public class Geometry
    {
        [DataMember]
        public Bounds bounds { get; set; }

        [DataMember]
        public Location location { get; set; }

        [DataMember]
        public string location_type { get; set; }

        [DataMember]
        public Viewport viewport { get; set; }
    }

    [DataContract]
    public class Result
    {
        [DataMember]
        public List<AddressComponent> address_components { get; set; }

        [DataMember]
        public string formatted_address { get; set; }

        [DataMember]
        public Geometry geometry { get; set; }

        [DataMember]
        public string place_id { get; set; }

        [DataMember]
        public List<string> types { get; set; }
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
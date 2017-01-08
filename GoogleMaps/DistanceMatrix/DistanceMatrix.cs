using System.Collections.Generic;

namespace GoogleMaps.DistanceMatrix
{
    /// <summary>
    /// Modos de Transporte usados na Google Maps Distance Matrix API.
    /// </summary>
    /// <see href="https://developers.google.com/maps/documentation/distance-matrix/intro#travel_modes"/>
    public enum TravelMode
    {
        Driving,
        Walking,
        Bicycling,
        Transit
    }
    public class Duration
    {
        public int value { get; set; }
        public string text { get; set; }
    }

    public class Distance
    {
        public int value { get; set; }
        public string text { get; set; }
    }

    public class Element
    {
        public string status { get; set; }
        public Duration duration { get; set; }
        public Distance distance { get; set; }
    }

    public class Row
    {
        public List<Element> elements { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public List<string> origin_addresses { get; set; }
        public List<string> destination_addresses { get; set; }
        public List<Row> rows { get; set; }
    }
}
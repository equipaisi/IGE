using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using GoogleMaps.DistanceMatrix;
using GoogleMaps.Geocoding;

namespace GoogleMaps
{
    [ServiceContract]
    public interface IGoogleMaps
    {
        /// <summary>
        /// Retorna as coordenadas de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        /// <returns>Latitude e longitude da localidade</returns>
        [OperationContract]
        Location GetCoordinates(string location);

        /// <summary>
        /// Retorna o <see cref="Place"/> de uma determinada <param name="location">localidade</param>.
        /// </summary>
        /// <param name="location">Localidade</param>
        [OperationContract]
        Place GetPlace(string location);

        /// <summary>
        /// Calcula a distância entre <paramref name="origin"></paramref> e <paramref name="destination"></paramref> para um determinado modo de transporte <paramref name="mode"></paramref>.
        /// </summary>
        /// <param name="origin">Origem</param>
        /// <param name="destination">Destino</param>
        /// <param name="mode">Modo de transporte</param>
        /// <returns>Distância entre <paramref name="origin"></paramref> e <paramref name="destination"></paramref></returns>
        [OperationContract]
        int DistanceBetween(Location origin, Location destination, TravelMode mode);
    }
}
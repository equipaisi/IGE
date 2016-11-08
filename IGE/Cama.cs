using System.ComponentModel;

namespace IGE
{
    //TODO: usar outro método para não ter que usar switches. é preferivel abstract class Cama <: class SingleCama
    public enum TipoCama { Single, Double }

    public interface ICama
    {
        /// <summary>
        /// Retorna o número máximo de pessoas que podem dormir nesta cama.
        /// </summary>
        int Capacidade { get; }
    }
    
    public class Cama : ICama
    {
        private readonly TipoCama _tipoCama;

        /// <summary>
        /// Constrói uma nova Cama.
        /// </summary>
        /// <param name="tipoCama">Tipo de cama.</param>
        public Cama(TipoCama tipoCama)
        {
            _tipoCama = tipoCama;
            switch (_tipoCama)
            {
                case TipoCama.Single:
                    Capacidade = 1;
                    break;
                case TipoCama.Double:
                    Capacidade = 2;
                    break;
                default: throw new InvalidEnumArgumentException("tipoCama tem que ser Single ou Double");
            }
        }
        
        /// <summary>
        /// Retorna o número máximo de pessoas que podem dormir nesta cama.
        /// </summary>
        public int Capacidade { get; }

        /// <summary>
        /// Retorna uma representação textual do tipo de cama.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Tipo: {_tipoCama}";
    }
}
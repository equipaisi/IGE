using System.Collections.Generic;
using System.Linq;

namespace Middleware
{
    public interface IQuarto
    {
        /// <summary>
        /// Retorna o número de camas do quarto.
        /// </summary>
        int NumeroDeCamas { get; }

        /// <summary>
        /// Retorna o número máximo de pessoas que podem dormir no quarto.
        /// </summary>
        int Capacidade { get; }
    }

    public class Quarto : IQuarto
    {
        #region Constructores
        public Quarto()
        {
            Camas = new List<ICama> { new Cama(TipoCama.Single) };
        }

        public Quarto(IEnumerable<ICama> camas)
        {
            Camas = camas;
        }
        #endregion

        public IEnumerable<ICama> Camas { get; set; }

        /// <summary>
        /// Retorna o número de camas do quarto.
        /// </summary>
        public int NumeroDeCamas => Camas.Count();
        /// <summary>
        /// Retorna o número máximo de pessoas que podem dormir no quarto.
        /// </summary>
        public int Capacidade => Camas.Sum(cama => cama.Capacidade);
    }
}
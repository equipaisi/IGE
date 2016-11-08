using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

    public class Quarto: IQuarto
    {
        public Quarto(IEnumerable<ICama> camas)
        {
            Contract.Requires(camas != null);
            Camas = camas;
            NumeroDeCamas = Camas.Count();
        }

        public IEnumerable<ICama> Camas { get; set; }
        /// <summary>
        /// Retorna o número de camas do quarto.
        /// </summary>
        public int NumeroDeCamas { get; }
        /// <summary>
        /// Retorna o número máximo de pessoas que podem dormir no quarto.
        /// </summary>
        public int Capacidade => Camas.Sum(cama => cama.Capacidade);
    }
}
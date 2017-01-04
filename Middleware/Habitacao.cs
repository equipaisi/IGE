using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Middleware
{
    /// <summary>
    /// Interface IHabitação.
    /// De acordo com o RF 1.1, uma Habitação deve ter:
    ///  - morada
    ///  - metros quadrados totais
    ///  - número de assoalhadas
    ///  - número de quartos
    ///  - ano de construção
    ///  - custo mensal
    ///  - fotografias
    ///  - comodidades (internet, televisão, serviço de limpeza)
    /// </summary>
    public interface IHabitacao
    {
        /// <summary>
        /// Retorna a morada completa da habitação.
        /// </summary>
        Morada Morada { get; set; }

        /// <summary>
        /// Retorna o número de metros quadrados totais da habitação.
        /// </summary>
        float MetrosQuadrados { get; set; }

        /// <summary>
        /// Retorna o número de camas na habitação.
        /// </summary>
        int NumeroDeCamas { get; }

        /// <summary>
        /// Retorna o número de assoalhadas da habitação.
        /// Uma assoalhada é qualquer compartimento de uma casa que não seja a despensa, a cozinha, o quarto de banho ou o hall.
        /// <remarks>O número de assoalhadas nunca poderá ser inferior ao número de quartos.</remarks>
        /// </summary>
        int NumeroDeAssoalhadas { get; set; }

        /// <summary>
        /// Retorna o número de quartos da habitação.
        /// </summary>
        int NumeroDeQuartos { get; }

        /// <summary>
        /// Retorna o número de Wc's da habitação.
        /// </summary>
        int NumeroDeWcs { get; set; }

        /// <summary>
        /// Retorna o ano de construção da habitação.
        /// </summary>
        int AnoDeConstrucao { get; set; }

        /// <summary>
        /// Retorna o custo/preço mensal da habitação.
        /// </summary>
        decimal CustoMensal { get; set; }

        /// <summary>
        /// Se o custo mensal da habitação inclui as despesas 
        /// mensais retorna true, senão retorna false. 
        /// </summary>
        bool IncluiDespesas { get; set; }

        /// <summary>
        /// Retorna todas as fotografias da habitação.
        /// <remarks>System.Drawing.Image suporta os seguintes formatos de imagem: BMP, GIF, JPEG, PNG, TIFF</remarks>
        /// </summary>
        IEnumerable<Image> Fotografias { get; set; }

        /// <summary>
        /// Retorna a struct <see cref="Comodidades"/> que contêm informação
        /// sobre se a habitação oferece televisão, internet e serviço de limpeza.
        /// </summary>
        Comodidades Comodidades { get; set; }

        /// <summary>
        /// Retorna uma descrição opcional da habitação.
        /// Todo o tipo de informação extra sobre a habitação deve ser introduzida nesta propriedade.
        /// </summary>
        string Descricao { get; set; }
    }

    /// <summary>
    /// Classe habitação.
    /// Representa uma Habitação para aluger.
    /// </summary>
    public class Habitacao : IHabitacao
    {
        #region Constructors
        /// <summary>
        /// Constrói uma nova Habitação.
        /// </summary>
        /// <param name="numeroDeQuartos">Número de quartos.</param>
        /// <param name="numeroDeAssoalhadas">Número de assoalhadas</param>
        /// <param name="numeroDeWcs">Número de wc's</param>
        /// <param name="metrosQuadrados">Metros quadrados</param>
        /// <param name="anoDeConstrucao">Ano de construção</param>
        /// <param name="morada">Morada</param>
        /// <param name="comodidades">Comodidades (Televisão, Internet, Serviço de Limpeza)</param>
        public Habitacao(string descricao, int numeroDeQuartos, int numeroDeAssoalhadas, int numeroDeWcs, float metrosQuadrados,
            int anoDeConstrucao, Morada morada, bool incluiDespesas, Comodidades comodidades = default(Comodidades))
        {
            /*if (numeroDeAssoalhadas < quartos.Count())
            {
                throw new ArgumentException();
            }*/
            var quartos = new List<IQuarto>(numeroDeQuartos);
            for (var _ = 0; _ < numeroDeQuartos; _++) quartos.Add(new Quarto());
            Descricao = descricao;
            Quartos = quartos;
            NumeroDeAssoalhadas = numeroDeAssoalhadas;
            NumeroDeWcs = numeroDeWcs;
            MetrosQuadrados = metrosQuadrados;
            AnoDeConstrucao = anoDeConstrucao;
            Morada = morada;
            Comodidades = comodidades;
            IncluiDespesas = incluiDespesas;
        }

        /// <summary>
        /// Constrói uma nova Habitação.
        /// </summary>
        /// <param name="quartos">Lista de quartos</param>
        /// <param name="numeroDeAssoalhadas">Número de assoalhadas</param>
        /// <param name="numeroDeWcs">Número de wc's</param>
        /// <param name="metrosQuadrados">Metros quadrados</param>
        /// <param name="anoDeConstrucao">Ano de construção</param>
        /// <param name="morada">Morada</param>
        /// <param name="comodidades">Comodidades (Televisão, Internet, Serviço de Limpeza)</param>
        public Habitacao(IEnumerable<IQuarto> quartos, int numeroDeAssoalhadas, int numeroDeWcs, float metrosQuadrados,
            int anoDeConstrucao, Morada morada, Comodidades comodidades = default(Comodidades))
        {
            /*if (numeroDeAssoalhadas < quartos.Count())
            {
                throw new ArgumentException();
            }*/
            Quartos = quartos;
            NumeroDeAssoalhadas = numeroDeAssoalhadas;
            NumeroDeWcs = numeroDeWcs;
            MetrosQuadrados = metrosQuadrados;
            AnoDeConstrucao = anoDeConstrucao;
            Morada = morada;
            Comodidades = comodidades;
        }
        #endregion

        /// <summary>
        /// Retorna a morada completa da habitação.
        /// </summary>
        public Morada Morada { get; set; }

        /// <summary>
        /// Retorna o número de metros quadrados totais.
        /// </summary>
        public float MetrosQuadrados { get; set; }
        /// <summary>
        /// Retorna os quartos da habitação.
        /// <returns>Quartos da habitação</returns>
        /// </summary>
        public IEnumerable<IQuarto> Quartos { get; set; }

        /// <summary>
        /// Retorna o número de quartos da habitação.
        /// <returns>Número de quartos da habitação.</returns>
        /// </summary>
        public int NumeroDeQuartos => Quartos.Count();

        /// <summary>
        /// Retorna o número de Wc's da habitação.
        /// </summary>
        public int NumeroDeWcs { get; set; }

        /// <summary>
        /// Retorna o número de assoalhadas da habitação.
        /// Uma assoalhada é qualquer compartimento de uma casa que não seja a despensa, a cozinha, o quarto de banho ou o hall.
        /// <remarks>O número de assoalhadas nunca poderá ser inferior ao número de quartos.</remarks>
        /// </summary>
        public int NumeroDeAssoalhadas { get; set; }

        /// <summary>
        /// Retorna o ano de construção da habitação.
        /// </summary>
        public int AnoDeConstrucao { get; set; }

        /// <summary>
        /// Retorna uma descrição opcional da habitação.
        /// Todo o tipo de informação extra sobre a habitação deve ser introduzida nesta propriedade.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Retorna todas as fotografias da habitação.
        /// <remarks>System.Drawing.Image suporta os seguintes formatos de imagem: BMP, GIF, JPEG, PNG, TIFF</remarks>
        /// </summary>
        public IEnumerable<Image> Fotografias { get; set; }

        /// <summary>
        /// Retorna o custo/preço mensal da habitação.
        /// </summary>
        public decimal CustoMensal { get; set; }

        /// <summary>
        /// Se o custo mensal da habitação inclui as despesas 
        /// mensais retorna true, senão retorna false. 
        /// </summary>
        public bool IncluiDespesas { get; set; }

        /// <summary>
        /// Retorna a struct <see cref="IHabitacao.Comodidades"/> que contêm informação
        /// sobre se a habitação oferece televisão, internet e serviço de limpeza.
        /// </summary>
        public Comodidades Comodidades { get; set; }

        // TODO: use a better name for this property?
        /// <summary>
        /// Retorna uma representação textual do número de quartos existentes na habitação.
        /// </summary>
        public string TQuartos => $"T{NumeroDeQuartos}";

        /// <summary>
        /// Retorna o número de pessoas que podem habitar na habitação.
        /// É igual à soma da capacidade de cada cama da habitação.
        /// <remarks>Este valor não deve ser visto como um indicador de disponibilidade de aluguer da habitação.</remarks>
        /// </summary>
        public int Capacidade => Quartos.Sum(q => q.Capacidade);

        /// <summary>
        /// Retorna o número de camas na habitação.
        /// TODO: existem camas duplas, ou melhor, camas para mais do que uma pessoa?
        /// TODO: Sim e apenas camas single e duplas.
        /// </summary>
        public int NumeroDeCamas => Quartos.Sum(q => q.NumeroDeCamas);
    }
}
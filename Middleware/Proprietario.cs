namespace Middleware
{
    /// <summary>
    /// Interface IProprietario.
    /// </summary>
    public interface IProprietario
    {
        /// <summary>
        /// Nome do proprietário.
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Número do Bilhete de Identidade do proprietário.
        /// </summary>
        string BI { get; set; }

        // TODO: adicionar o resto da informação necessária para um proprietário
    }

    /// <summary>
    /// Classe Proprietário.
    /// </summary>
    public class Proprietario : IProprietario
    {
        #region Contructors

        public Proprietario(string nome)
        {
            Nome = nome;
            BI = string.Empty;
        }

        public Proprietario(string nome, string bi)
        {
            Nome = Nome;
            BI = bi;
        }

        #endregion

        /// <summary>
        /// Nome do proprietário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Número do Bilhete de Identidade do proprietário.
        /// </summary>
        public string BI { get; set; }
    }
}

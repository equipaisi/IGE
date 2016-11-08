using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Middleware
{
    public interface IFuncionario: IUtilizador
    {
        GeneroSexual Genero { get; set; }
    }

    public sealed class Funcionario : Utilizador, IFuncionario
    {
        /// <summary>
        /// Constrói um novo funcionário.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <example>var f = new Funcionario("João", "Ferreira", new[] {"Oliveira", "Garcia"}, "jferreira@imovcelos.pt");</example>
        /// <param name="username">Username do funcionário.</param>
        /// <param name="primeiroNome">Primeiro nome do funcionário.</param>
        /// <param name="ultimoNome">Último nome do funcionário.</param>
        /// <param name="nomesIntermedios"></param>
        /// <param name="email">Endereço electrónico do funcionário.</param>
        public Funcionario(string primeiroNome, string ultimoNome, IEnumerable<string> nomesIntermedios, string username, string password, string email) : base()
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrWhiteSpace(primeiroNome), "Primeiro nome do funcionário não pode ser null ou vazio");
            Contract.Requires<ArgumentException>(!string.IsNullOrWhiteSpace(ultimoNome), "Último nome do funcionário não pode ser null ou vazio");
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            NomesIntermedios = nomesIntermedios ?? new List<string>();
            if (Middleware.Username.Valid(username))
            {
                Username = username;
            } else
            {
                throw new ArgumentException("Username não pode ser null ou apenas conter espaços em branco.", paramName: nameof(username));
            }
            Email = new MailAddress(email);
            PasswordHash = Middleware.PasswordHash.HashPassword(password);
        }

        /// <summary>
        /// <remarks>Obrigatório</remarks>
        /// </summary>
        public string PrimeiroNome { get; }
        /// <summary>
        /// <remarks>Obrigatório</remarks>
        /// </summary>
        public string UltimoNome { get; }
        public IEnumerable<string> NomesIntermedios { get; }

        #region Utilizador / IUtilizador
        public override string Username { get; }
        public override string PasswordHash { get; }
        /// <summary>
        /// O email do utilizador.
        /// TODO: email type
        /// </summary>
        public override MailAddress Email { get; set; }

        /// <summary>
        /// O nome completo do utilizador.
        /// </summary>
        public override string NomeCompleto
        {
            // TODO: refactor this into one line solution
            get
            {
                var names = new List<string> {PrimeiroNome};
                names.AddRange(NomesIntermedios);
                names.Add(UltimoNome);
                return string.Join(" ", names);
            }
            
        }

        #endregion

        /// <summary>
        /// Retorna o primeiro e último nome do utilizador.
        /// </summary>
        public string NomeCurto => $"{PrimeiroNome} {UltimoNome}";



        public GeneroSexual Genero { get; set; }
    }
}

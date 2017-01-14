using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Middleware
{
    /// <summary>
    /// Interface IFuncionário.
    /// </summary>
    public interface IFuncionario: IUtilizador
    {   
        /// <summary>
        /// O género sexual do funcionário.
        /// </summary>
        GeneroSexual Genero { get; set; }
    }

    public sealed class Funcionario : Utilizador, IFuncionario
    {
        #region Constructors
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
        /// <param name="password">Password em cleartext do funcionário.</param>
        public Funcionario(string primeiroNome, string ultimoNome, IEnumerable<string> nomesIntermedios, string username, string password, string email)
        {
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
        #endregion

        #region Utilizador / IUtilizador

        public override string TypeDescriptor => "funcionario";
        public override string Username { get; set; }
        public override string PasswordHash { get; set; }
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
            set
            {
                var names = value.Split(' ');
                var namesLength = names.Length;
                switch (namesLength)
                {
                    case 1:
                        PrimeiroNome = names[0];
                        NomesIntermedios = null;
                        UltimoNome = null;
                        break;
                    case 2:
                        PrimeiroNome = names[0];
                        NomesIntermedios = null;
                        UltimoNome = names[1];
                        break;
                    default:
                        PrimeiroNome = names[0];
                        NomesIntermedios = names.AsEnumerable().Skip(1).Take(namesLength - 2);
                        UltimoNome = names[1];
                        break;
                }
            }

        }
        #endregion

        #region IFuncionario
        public GeneroSexual Genero { get; set; }
        #endregion

        /// <summary>
        /// <remarks>Obrigatório</remarks>
        /// </summary>
        public string PrimeiroNome { get; set; }
        /// <summary>
        /// <remarks>Obrigatório</remarks>
        /// </summary>
        public string UltimoNome { get; set; }
        public IEnumerable<string> NomesIntermedios { get; set; }
        /// <summary>
        /// Retorna o primeiro e último nome do utilizador.
        /// </summary>
        public string NomeCurto => $"{PrimeiroNome} {UltimoNome}";
    }
}

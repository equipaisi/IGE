using System;
using System.Net.Mail;

namespace Middleware
{
    /// <summary>
    /// Um utilizador corresponde à ideia de uma conta no sistema.
    /// </summary>
    public interface IUtilizador
    {
        /// <summary>
        /// O username do utilizador.
        /// </summary>
        string Username { get; set; } // TODO: make Username type, think about password policy checking
        /// <summary>
        /// A hash da password do utilizador.
        /// TODO: use a hash function like
        /// </summary>
        string PasswordHash { get; set; }
        /// <summary>
        /// O nome completo do utilizador.
        /// </summary>
        string NomeCompleto { get; set; }
        /// <summary>
        /// O email do utilizador.
        /// TODO: email type
        /// </summary>
        MailAddress Email { get; set; }
        /// <summary>
        /// A data de criação desta conta de utilizador.
        /// </summary>
        // TODO: data de última modificação, ou lista de modificações e datas associadas? ou nada?
        DateTime DataDeCriacao { get; }
        /// <summary>
        /// Um par (username, password) deste utilizador.
        /// </summary>
        //Tuple<string,string> Credentiais { get; }
    }

    public abstract class Utilizador : IUtilizador
    {
        protected Utilizador()
        {
           DataDeCriacao = DateTime.Now;
        }

        public abstract string Username { get; set; }
        public abstract string PasswordHash { get; set; }
        public abstract string NomeCompleto { get; set; }
        public abstract MailAddress Email { get; set; }
        public DateTime DataDeCriacao { get; }
        //public abstract Tuple<string, string> Credentiais { get; }
    }
}

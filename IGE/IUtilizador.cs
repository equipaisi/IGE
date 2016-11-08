using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IGE
{
    /// <summary>
    /// Um utilizador corresponde à ideia de uma conta no sistema.
    /// </summary>
    public interface IUtilizador
    {
        /// <summary>
        /// O username do utilizador.
        /// </summary>
        string Username { get; } // TODO: make Username type, think about password policy checking
        /// <summary>
        /// A hash da password do utilizador.
        /// TODO: use a hash function like
        /// </summary>
        string PasswordHash { get; }
        /// <summary>
        /// O nome completo do utilizador.
        /// </summary>
        string NomeCompleto { get; }
        /// <summary>
        /// O email do utilizador.
        /// TODO: email type
        /// </summary>
        MailAddress Email { get; set; }
        /// <summary>
        /// A data de criação desta conta de utilizador.
        /// </summary>
        DateTime DataDeCriacao { get; }
        // TODO: data de última modificação, ou lista de modificações e datas associadas? ou nada?
    }

    public abstract class Utilizador : IUtilizador
    {
        protected Utilizador()
        {
           DataDeCriacao = DateTime.Now;
        }

        public abstract string Username { get; }
        public abstract string PasswordHash { get; }
        public abstract string NomeCompleto { get; }
        public abstract MailAddress Email { get; set; }
        public DateTime DataDeCriacao { get; }
    }
}

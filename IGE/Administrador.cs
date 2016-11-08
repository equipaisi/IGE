using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IGE
{
    public interface IAdministrador : IUtilizador
    {

    }
    
    public sealed class Administrador : Utilizador, IAdministrador
    {
        public Administrador(string nomeCompleto, string username, string password, string email)
        {
            NomeCompleto = nomeCompleto; // todo: validar? String.IsNullOrWhiteSpace
            Username = username; // todo: validar?
            Email = new MailAddress(email);
            PasswordHash = IGE.PasswordHash.HashPassword(password);
        }

        #region Utilizador / IUTilizador
        public override string Username { get; }
        public override string PasswordHash { get; }
        public override string NomeCompleto { get; }
        public override MailAddress Email { get; set; }
        #endregion

        public override string ToString() => $"Administrador:\nNome: {NomeCompleto}\nUsername: {Username}\nEmail: {Email}\nHash: {PasswordHash}";
    }
}

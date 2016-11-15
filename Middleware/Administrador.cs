using System.Net.Mail;

namespace Middleware
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
            PasswordHash = Middleware.PasswordHash.HashPassword(password);
        }

        #region Utilizador / IUTilizador
        public override string Username { get; set; }
        public override string PasswordHash { get; set; }
        public override string NomeCompleto { get; set; }
        public override MailAddress Email { get; set; }
        #endregion

        public override string ToString() => $"Administrador:\nNome: {NomeCompleto}\nUsername: {Username}\nEmail: {Email}\nHash: {PasswordHash}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Middleware
{
    public interface IMiddlewareClient
    {
        void DropDatabase();
        void PopulateDatabase();
        string GetUserType(string username, string password);
    }

    public class MiddlewareClient : IMiddlewareClient
    {
        private readonly MySqlDb _db;

        public MiddlewareClient()
        {
            _db = new MySqlDb();
        }

        public void CreateDatabase()
        {
            _db.Open();
            _db.CreateDatabaseAndTables();
            _db.Close();
        }

        public void DropDatabase()
        {
            _db.Open();
            _db.DropDatabase();
            _db.Close();
        }

        public void PopulateDatabase()
        {
            _db.Open();
            // TODO: get data from external file
            var users = new List<IUtilizador>
            {
                new Funcionario("João", "Ferreira", null, "jferreira", "jferreira", "jferreira@imovcelos.pt"),
                new Funcionario("Sónia", "Gomes", null, "sgomes", "sgomes", "sgomes@imovcelos.pt"),
                new Administrador("António Fonseca", "afonseca", "afonseca", "afonseca@imovcelos.pt")
            };

            // TODO: error handling, make sure each command returns the appropriate result (number of rows affected?)
            var r1 = _db.PopulateUserTypeTable(new List<string> {"funcionario", "administrador"});
            // TODO: var r2 = _db.PopulateUserTable(users);
            _db.Close();
        }

        public string GetUserType(string username, string password)
        {
            _db.Open();
            //TODO: get encryption working  _db.GetUserPasswordHash(username) == PasswordHash.HashPassword(password) ? _db.GetUserUserTypeDescription(username) : null;
            var passwordHash = _db.GetUserPasswordHash(username);
            if (passwordHash == null) return null;
            var usertype =  passwordHash == password ? _db.GetUserUserTypeDescription(username) : null;
            _db.Close();
            return usertype;
        }

        private static string CreateUserRows(IEnumerable<IUtilizador> users)
        {
            var userRows = new List<string>();
            userRows.AddRange(users.Select(CreateUserRow));
            return string.Join(",", userRows);
        }

        /// <summary>
        ///     Cria uma string que representa um valor de User a ser inserido na tabela User.
        /// </summary>
        /// <example>('jfonseca','jfonseca@foo.com','passwordsecreta','1')</example>
        private static string CreateUserRow(IUtilizador user)
            =>
                string.Join(",",
                    new List<string>
                    {
                        "(",
                        user.Username,
                        user.Email.Address,
                        user.PasswordHash,
                        user.TypeDescriptor,
                        ")"
                    });
    }
}

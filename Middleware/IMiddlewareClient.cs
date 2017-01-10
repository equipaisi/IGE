using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Middleware
{
    public interface IMiddlewareClient
    {
        string GetUserType(string username);
        string GetPassword(string username, string password);
        bool CreateFuncionario(string username, string password);
        bool CreateAdmin(string username, string password);

        bool DeleteUser(string username);
    }

    public class MiddlewareClient : IMiddlewareClient
    {
        private readonly MySqlDatabaseConnection _db;

        public MiddlewareClient()
        {
            _db = new MySqlDatabaseConnection();
        }

        public MiddlewareClient(string databaseName)
        {
            _db = new MySqlDatabaseConnection(ConnectionStringFromAppConfig(databaseName));
        }

        /// <summary>
        ///     Retorna o valor da connectionString na App.config do Frontend.
        /// </summary>
        private static string ConnectionStringFromAppConfig(string databaseName)
            => ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

        public string GetUserType(string username)
        {
            _db.Open();
            int userId = _db.GetUserType(username);
            string usertype = string.Empty; 
            switch (userId)
            {
                case 0:
                    usertype = "administrador";
                    break;
                case 1:
                    usertype = "funcionario";
                    break;
            }
            _db.Close();
            return usertype;
        }

        public string GetPassword(string username, string password)
        {
            _db.Open();
            string r = _db.ValidateCredentials(username, password);
            _db.Close();
            return r;
        }


        public bool CreateFuncionario(string username, string password)
        {
            _db.Open();
            int r = _db.CreateFuncionario(username, password);
            _db.Close();
            return r == 0;
        }


        public bool CreateAdmin(string username, string password)
        {
            _db.Open();
            int r = _db.CreateAdmin(username, password);
            _db.Close();
            return r == 0;
        }

        public bool DeleteUser(string username)
        {
            _db.Open();
            int r = _db.DeleteUser(username);
            _db.Close();
            return r > 0;
        }
    }
}

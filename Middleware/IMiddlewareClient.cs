﻿using System;
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
        void DropDatabase();
        void CreateDatabase();
        void PopulateDatabase();
        string GetUserType(string username, string password);
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
            List<IUtilizador> users = new List<IUtilizador>
            {
                new Funcionario("João", "Ferreira", null, "jferreira", "jferreira", "jferreira@imovcelos.pt"),
                new Funcionario("Sónia", "Gomes", null, "sgomes", "sgomes", "sgomes@imovcelos.pt"),
                new Administrador("António Fonseca", "afonseca", "afonseca", "afonseca@imovcelos.pt")
            };

            // TODO: error handling, make sure each command returns the appropriate result (number of rows affected?)
            int r1 = _db.PopulateUserTypeTable(new List<string> {"funcionario", "administrador"});
            // TODO: var r2 = _db.PopulateUserTable(users);
            _db.Close();
        }

        public string GetUserType(string username, string password)
        {
            _db.Open();
            //TODO: get encryption working  _db.GetUserPasswordHash(username) == PasswordHash.HashPassword(password) ? _db.GetUserUserTypeDescription(username) : null;
            string passwordHash = _db.GetUserPasswordHash(username);
            if (passwordHash == null) return null;
            string usertype =  passwordHash == password ? _db.GetUserUserTypeDescription(username) : null;
            _db.Close();
            return usertype;
        }

        private static string CreateUserRows(IEnumerable<IUtilizador> users)
        {
            List<string> userRows = new List<string>();
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

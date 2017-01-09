using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Backend
{
    public sealed class MySqlDatabaseConnection : IDatabaseConnection
    {
        private readonly MySqlConnection _con;

        #region Constructors

        /// <summary>
        ///     Construtor por defeito de MySqlDatabaseConnection.
        ///     Lê a connection string a partir da App.config do Frontend.
        /// </summary>
        public MySqlDatabaseConnection()
        {
            _con = new MySqlConnection(ConnectionStringFromAppConfig("IGE"));
        }

        public MySqlDatabaseConnection(string connectionString)
        {
            _con = new MySqlConnection(connectionString);
        }

        #endregion

        #region IDatabaseConnection

        public void Open() => _con.Open();
        public Task OpenAsync() => _con.CloseAsync();
        public void Close() => _con.Close();
        public Task CloseAsync() => _con.CloseAsync();
        public void Dispose() => _con.Dispose();
        public object Clone() => _con.Clone();

        #endregion

        /// <summary>
        ///     Retorna o valor da connectionString na App.config do Frontend.
        /// </summary>
        private static string ConnectionStringFromAppConfig(string databaseName)
            => ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

        /// <summary>
        ///     Retorna o nome da base de dados atual ou a base de dados a ser usada após a abertura da conexão.
        ///     O nome da base de dados foi préviamente especificado na connection string.
        /// </summary>
        private string DatabaseName => _con.Database;

        #region Queries

        public int GetUserType(string username) => Convert.ToInt32(GetUserTypeCommand(username).ExecuteScalar());

        private MySqlCommand GetUserTypeCommand(string username)
        {
            return new MySqlCommand($"SELECT CODIGO FROM `{DatabaseName}`.`TBL_UTILIZADOR` WHERE NOME_CONTA = '{username}';", _con);
        }

        public string ValidateCredentials(string username, string password)
        {
            string passwordDb = (string) ValidateCredentialsCommand(username).ExecuteScalar();
            return passwordDb;
        }

        private MySqlCommand ValidateCredentialsCommand(string username)
        {
            return new MySqlCommand($"SELECT PASSWORD FROM `{DatabaseName}`.`TBL_UTILIZADOR` WHERE NOME_CONTA = '{username}';", _con);
        }

        #endregion
    }
}

using System;
using System.Configuration;
using System.Data.OleDb;
using System.Threading.Tasks;
using Middleware;
using MySql.Data.MySqlClient;

namespace Backend
{
    public interface IDbConnection : IDisposable, ICloneable
    {
        void Initialize(string server, string database);
        void Open();
        void Close();
        /// <summary>
        /// Abrir assincronamente a conecção à base de dados.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task OpenAsync();
        /// <summary>
        /// Fechar assincronamente a conecção à base de dados.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task CloseAsync();
    }

    public class MySqlDb : IDbConnection
    {
        private MySqlConnection _con;
        private string _uid;
        private string _password;

        public MySqlDb(string server = "localhost", string database = "ige")
        {
            Initialize(server, database);
        }

        #region Métodos
        public void Initialize(string server = "localhost", string database = "ige")
        {
            //var connString = GetConnectionStringFromAppConfig();
            _uid = "igeuser";
            _password = "password";
            _con = new MySqlConnection($"SERVER={server};DATABASE={database};UID={_uid};PASSWORD={_password};"); // $"SERVER={server};DATABASE={database};UID={_uid};PASSWORD={_password};"
        }

        // TODO: read configuration from configuration file
        private string GetConnectionStringFromAppConfig()
        {
            return ConfigurationManager.ConnectionStrings["Dev"].ConnectionString;
        }

        public void Open() => _con.Open();
        public Task OpenAsync() => _con.CloseAsync();

        public void Close() => _con.Close();

        public Task CloseAsync() => _con.CloseAsync();

        public void Dispose() => _con.Dispose();
        public object Clone() => _con.Clone();

        #region Queries
        // Estes métodos de registar não devem estar acessíveis ao exterior. Eventualmente remover daqui.
        //TODO: RegistarAdministrador(string username, string password, string nome, string email)
        public void RegistarFuncionario(string username, string password, string nome, string email)
        {
            // Primeiro vemos qual o utilizador_tipo_id para um funcionário.
            const string userTypeQuery = "SELECT utilizador_tipo_id FROM utilizador_tipo WHERE utilizador_tipo_tipo = `funcionario`";
            var cmd1 = new MySqlCommand(userTypeQuery, _con);
            int userId = (int) cmd1.ExecuteScalar();

            // Depois inserimos um novo utilizador
            const string query = "INSERT INTO `ige`.`utilizador` (`username`, `nome`, `email`, `password_hash`, `data_de_criacao`, `utilizador_tipo_id`) VALUES(?,?,?,?,?,?);";
            var cmd2 = new MySqlCommand(query, _con);
            // todo: validar dados
            cmd2.Parameters.Add(new MySqlParameter("username", username));
            cmd2.Parameters.Add(new MySqlParameter("nome", nome));
            cmd2.Parameters.Add(new MySqlParameter("email", email));
            cmd2.Parameters.Add(new MySqlParameter("password_hash", PasswordHash.HashPassword(password)));
            cmd2.Parameters.Add(new MySqlParameter("utilizador_tipo_id", userId));
            Console.WriteLine(cmd2.CommandText);
        }

        public bool ValidUser(string username, string password)
        {
            const string query = "SELECT password_hash FROM utilizador WHERE username = ?";
            var command = new MySqlCommand(query, _con);
            command.Parameters.Add(new MySqlParameter("username", username));
            var reader = command.ExecuteScalar();
            if (reader == null) return false; // got nothing
            var passwordHash = reader.ToString();
            return PasswordHash.ValidatePassword(username, passwordHash);
        }
        #endregion
        #endregion
    }

    /*
    public static class Configuration
    {
        public static void Read()
        {
            //var env = ConfigurationManager.AppSettings["current_environment"];
            Console.WriteLine(ConfigurationManager.AppSettings.AllKeys);
        }
    }

    public class Program
    {
        public static void Main(string[] _)
        {
            Configuration.Read();
        }
    }
    */
}

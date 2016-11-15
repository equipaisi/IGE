using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Backend
{
    public interface IDbConnection : IDisposable, ICloneable
    {
        void Initialize(string server, string database);
        /// <summary>
        /// Abrir assincronamente a conecção à base de dados.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task Open();
        /// <summary>
        /// Fechar assincronamente a conecção à base de dados.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task Close();
    }

    public class MySqlDbCon : IDbConnection
    {
        MySqlConnection _con;
        string _uid;
        string _password;

        public MySqlDbCon(string server = "localhost", string database = "ige")
        {
            Initialize(server, database);
        }

        #region Métodos
        public void Initialize(string server = "localhost", string database = "ige")
        {
            _uid = "username";
            _password = "password";
            _con = new MySqlConnection($"SERVER={server};DATABASE={database};UID={_uid};PASSWORD={_password};");
        }

        public Task Open() => _con.OpenAsync();
        public Task Close() => _con.CloseAsync();
        public void Dispose() => _con.Dispose();
        public object Clone() => _con.Clone();
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

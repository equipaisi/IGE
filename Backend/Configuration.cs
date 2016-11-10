using System;
using System.Threading.Tasks;
using Backend;
using MySql.Data.MySqlClient;

namespace Backend
{
    public interface IDbConnection: IDisposable
    {
        void Initialize(string server, string database);
        Task Open();
        Task Close();
    }

    public class MySqlDbCon: IDbConnection
    {
        private MySqlConnection con;
        private string uid;
        private string password;

        public MySqlDbCon(string server = "localhost", string database = "ige")
        {
            Initialize(server, database);
        }

        public void Initialize(string server = "localhost", string database = "ige")
        {
            uid = "username";
            password = "password";
            con = new MySqlConnection($"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};");
        }

        public Task Open() => con.OpenAsync();

        public Task Close() => con.CloseAsync();
        public void Dispose() => con.Dispose();
    }
}

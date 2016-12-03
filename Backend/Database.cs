using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using Middleware;
using MySql.Data.MySqlClient;

namespace Backend
{
    public interface IDbConnection : IDisposable, ICloneable
    {
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
        private readonly string _database;

        #region Constructors
        public MySqlDb()
        {
            var connString = GetConnectionStringFromAppConfig();
            // DEBUG: Console.WriteLine($"Connection string from App.config {connString}");
            _con = new MySqlConnection(connString);
            _database = _con.Database;
        }

        public MySqlDb(string uid, string password, string server = "localhost", string database = "ige")
        {
            _con = new MySqlConnection($"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};");
            _database = _con.Database;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Lê o valor da connectionString na App.config do Frontend.
        /// </summary>
        /// <returns></returns>
        private string GetConnectionStringFromAppConfig()
        {
            return ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
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
        /*
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
        }*/

        // TODO: apagar este código na versão final
        public void DropDatabase()
        {
            const string dropDbStmt = "DROP DATABASE IF EXISTS `@dbname`;";
            var cmd = new MySqlCommand(dropDbStmt, _con);
            //cmd.Prepare();
            cmd.Parameters.AddWithValue("@dbname", this._database);
            Console.WriteLine("Executing " + cmd.CommandText);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Cria a base de dados e as suas tabelas;
        /// </summary>
        /// <returns></returns>
        public bool CreateDatabaseAndTables()
        {
            const string createDbStmt = "CREATE DATABASE IF NOT EXISTS `@dbname`;";
            var cmd1 = new MySqlCommand(createDbStmt, _con);
            cmd1.Prepare();
            cmd1.Parameters.AddWithValue("@dbname", this._database);
            Console.WriteLine("Executing " + cmd1.CommandText);
            var r1 = Convert.ToInt32(cmd1.ExecuteNonQuery());

            const string createUserTypeTableStmt = @"CREATE TABLE IF NOT EXISTS `@dbname`.`UserType` (
                                                      `UserTypeId` INT UNSIGNED NOT NULL AUTO_INCREMENT,
                                                      `UserTypeDescription` VARCHAR(45) NOT NULL,
                                                      PRIMARY KEY (`UserTypeId`),
                                                      UNIQUE INDEX `UserTypeId_UNIQUE` (`UserTypeId` ASC),
                                                      UNIQUE INDEX `UserTypeDescription_UNIQUE` (`UserTypeDescription` ASC))
                                                    ENGINE = InnoDB;";
            var cmd2 = new MySqlCommand(createUserTypeTableStmt, _con);
            cmd2.Parameters.AddWithValue("@dbname", this._database);
            var r2 = Convert.ToInt32(cmd2.ExecuteNonQuery());

            const string createUserTableStmt = @"CREATE TABLE IF NOT EXISTS `@dbname`.`User` (
                                                  `UserId` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
                                                  `UserTypeId` INT UNSIGNED NOT NULL,
                                                  `Username` VARCHAR(45) NOT NULL,
                                                  `Email` VARCHAR(100) NOT NULL,
                                                  `PasswordHash` CHAR(128) NOT NULL,
                                                  `DataDeCriacao` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
                                                  PRIMARY KEY (`UserId`),
                                                  UNIQUE INDEX `UserId_UNIQUE` (`UserId` ASC),
                                                  UNIQUE INDEX `Email_UNIQUE` (`Email` ASC),
                                                  UNIQUE INDEX `Username_UNIQUE` (`Username` ASC),
                                                  INDEX `fk_User_UserType_idx` (`UserTypeId` ASC),
                                                  CONSTRAINT `fk_User_UserType`
                                                    FOREIGN KEY (`UserTypeId`)
                                                    REFERENCES `@dbname`.`UserType` (`UserTypeId`)
                                                    ON DELETE NO ACTION
                                                    ON UPDATE NO ACTION)
                                                ENGINE = InnoDB;";
            var cmd3 = new MySqlCommand(createUserTableStmt, _con);
            cmd3.Parameters.AddWithValue("@dbname", this._database);
            var r3 = Convert.ToInt32(cmd2.ExecuteNonQuery());

            return new List<int> {r1, r2, r3}.All(v => v == 0); // se todos os resultados da execução dos comandos tiverem sido 0 então tudo correu bem
        }

        /// <summary>
        /// Popula a base de dados.
        /// </summary>
        /// <returns></returns>
        public bool PopulateDatabase()
        {
            const string populateUserTypeTable = "INSERT INTO `@dbname`.`UserType` (`UserTypeDescription`) VALUES ('funcionario'), ('administrador'), ('estudante');";
            var cmd1 = new MySqlCommand(populateUserTypeTable, _con);
            cmd1.Parameters.AddWithValue("@dbname", this._database);
            var r1 = Convert.ToInt32(cmd1.ExecuteNonQuery());

            const string funcionarioQuery = "SELECT `UserTypeId` FROM `@dbname`.`UserType` WHERE `UserTypeDescription` = 'funcionario';";
            var cmd2 = new MySqlCommand(funcionarioQuery, _con);
            cmd2.Parameters.AddWithValue("@dbname", this._database);
            var funcionarioId = Convert.ToInt32(cmd2.ExecuteScalar());

            const string administradorQuery = "SELECT `UserTypeId` FROM `@dbname`.`UserType` WHERE `UserTypeDescription` = 'administrador';";
            var cmd3 = new MySqlCommand(administradorQuery, _con);
            cmd3.Parameters.AddWithValue("@dbname", this._database);
            var administradorId = Convert.ToInt32(cmd3.ExecuteScalar());

            const string populateUserTable = @"INSERT INTO `@dbname`.`User` (`Username`, `Email`, `PasswordHash`, `UserTypeId`) VALUES
                              ('jferreira', 'jferreira@imovcelos.pt', 'foo', @funcionarioId),
                              ('sgomes', 'sgomes@imovcelos.pt', 'bar', @funcionarioId),
                              ('afonseca', 'afonseca@imovcelos.pt', 'tar', @administradorId);";
            var cmd4 = new MySqlCommand(populateUserTable, _con);
            cmd4.Parameters.AddWithValue("@dbname", this._database);
            cmd4.Parameters.AddWithValue("@funcionarioId", funcionarioId);
            cmd4.Parameters.AddWithValue("@administradorId", administradorId);
            var r2 = Convert.ToInt32(cmd2.ExecuteNonQuery());

            return new List<int> { r1, r2 }.All(v => v == 0); // se todos os resultados da execução dos comandos tiverem sido 0 então tudo correu bem
        }

        /// <summary>
        /// Faz a autenticação de um utilizador. 
        /// </summary>
        /// <param name="username">Username do utilizador</param>
        /// <param name="password">Password do utilizador</param>
        /// <returns></returns>
        public string ValidUser(string username, string password)
        {
            const string query = "SELECT PasswordHash, UserTypeDescription FROM User NATURAL JOIN UserType WHERE Username = ?";
            var command = new MySqlCommand(query, _con);
            command.Parameters.Add(new MySqlParameter("Username", username));
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    var passwordHash = reader.GetString(reader.GetOrdinal("PasswordHash"));
                    var userType = reader.GetString(reader.GetOrdinal("userTypeDescription"));

                    if (password == passwordHash) return userType;
                    return null;
                    //return new Tuple<bool, string>(PasswordHash.ValidatePassword(username, passwordHash), userType);
                }
            }
            return null;
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

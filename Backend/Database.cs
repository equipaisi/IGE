using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Middleware;
using MySql.Data.MySqlClient;

namespace Backend
{
    /// <summary>
    /// Representa uma conexão à base de dados.
    /// </summary>
    public interface IDbConnection : IDisposable, ICloneable
    {
        /// <summary>
        /// Abre uma nova conexão à base de dados.
        /// </summary>
        void Open();
        /// <summary>
        /// Fecha a conexão atual à base de dados.
        /// </summary>
        void Close();
        /// <summary>
        /// Abre uma nova conexão à base de dados assincronamente.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task OpenAsync();
        /// <summary>
        /// Fecha a conexão atual à base de dados assincronamente.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task CloseAsync();
    }

    public sealed class MySqlDb : IDbConnection
    {
        private readonly MySqlConnection _con;

        #region Constructors
        /// <summary>
        /// Construtor por defeito de MySqlDb.
        /// Lê a connection string a partir da App.config do Frontend.
        /// </summary>
        public MySqlDb()
        {
            _con = new MySqlConnection(ConnectionStringFromAppConfig);
        }

        public MySqlDb(string uid, string password, string server = "localhost", string database = "ige")
        {
            _con = new MySqlConnection($"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};");
        }
        #endregion

        #region IDbConnection

        public void Open() => _con.Open();
        public Task OpenAsync() => _con.CloseAsync();
        public void Close() => _con.Close();
        public Task CloseAsync() => _con.CloseAsync();
        public void Dispose() => _con.Dispose();
        public object Clone() => _con.Clone();

        #endregion

        /// <summary>
        /// Retorna o valor da connectionString na App.config do Frontend.
        /// </summary>
        private static string ConnectionStringFromAppConfig => ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;

        /// <summary>
        /// Retorna o nome da base de dados atual ou a base de dados a ser usada após a abertura da conexão.
        /// O nome da base de dados foi préviamente especificado na connection string.
        /// </summary>
        private string DatabaseName => _con.Database;

        #region Queries

        #region DropDatabase

        /// <summary>
        /// Apaga a base de dados com o nome <see cref="DatabaseName"/>.
        /// </summary>
        public void DropDatabase()
        {
            DropDatabaseCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Retorna o comando que apaga a base de dados com o nome <see cref="DatabaseName"/>.
        /// </summary>
        private MySqlCommand DropDatabaseCommand => new MySqlCommand($"DROP DATABASE IF EXISTS `{DatabaseName}`;", _con);

        #endregion

        /// <summary>
        /// Cria a base de dados <see cref="DatabaseName"/> e as tabelas necessárias;
        /// </summary>
        public void CreateDatabaseAndTables()
        {
            try
            {
                CreateDatabase();
                CreateUserTypeTable();
                CreateUserTable();
            }
            catch (IncorrectNumberOfAffectedRows)
            {
                //TODO
            }
        }

        #region CreateDatabase

        /// <summary>
        /// Cria a base de dados com o nome <see cref="DatabaseName"/>.
        /// </summary>
        private void CreateDatabase()
        {
            const int expectedAffectedRows = 1;
            var affectedRows = CreateDatabaseCommand.ExecuteNonQuery();
            if (affectedRows != expectedAffectedRows)
                throw new IncorrectNumberOfAffectedRows(affectedRows, expectedAffectedRows);
        }

        /// <summary>
        /// Retorna o comando que cria a base de dados com o nome <see cref="DatabaseName"/>.
        /// </summary>
        private MySqlCommand CreateDatabaseCommand => new MySqlCommand($"CREATE DATABASE IF NOT EXISTS `{DatabaseName}`;", _con);

        #endregion

        #region CreateUserTypeTable

        /// <summary>
        /// Cria a tabela UserType.
        /// </summary>
        private void CreateUserTypeTable()
        {
            const int expectedAffectedRows = 0;
            var affectedRows = CreateUserTypeTableCommand.ExecuteNonQuery();
            if (affectedRows != expectedAffectedRows)
                throw new IncorrectNumberOfAffectedRows(affectedRows, expectedAffectedRows);
        }

        /// <summary>
        /// Retorna o comando que cria a tabela UserType.
        /// </summary>
        private MySqlCommand CreateUserTypeTableCommand => new MySqlCommand(
            $@"CREATE TABLE IF NOT EXISTS `{DatabaseName}`.`UserType` (
                                                      `UserTypeId` INT UNSIGNED NOT NULL AUTO_INCREMENT,
                                                      `UserTypeDescription` VARCHAR(45) NOT NULL,
                                                      PRIMARY KEY (`UserTypeId`),
                                                      UNIQUE INDEX `UserTypeId_UNIQUE` (`UserTypeId` ASC),
                                                      UNIQUE INDEX `UserTypeDescription_UNIQUE` (`UserTypeDescription` ASC))
                                                    ENGINE = InnoDB;",
            _con);

        #endregion

        #region CreateUserTable

        /// <summary>
        /// Cria a tabela User.
        /// </summary>
        /// <returns></returns>
        private void CreateUserTable()
        {
            const int expectedAffectedRows = 0;
            var affectedRows = CreateUserTableCommand.ExecuteNonQuery();
            if (affectedRows != expectedAffectedRows)
                throw new IncorrectNumberOfAffectedRows(affectedRows, expectedAffectedRows);
        }

        /// <summary>
        /// Retorna o comando que cria a tabela User.
        /// </summary>
        private MySqlCommand CreateUserTableCommand
            =>
                new MySqlCommand(
                    $@"CREATE TABLE IF NOT EXISTS `{DatabaseName}`.`User` 
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
                                                    REFERENCES `{DatabaseName}`.`UserType` (`UserTypeId`)
                                                    ON DELETE NO ACTION
                                                    ON UPDATE NO ACTION)
                                                ENGINE = InnoDB;",
                    _con);

        #endregion

        #region PopulateDatabase
        /// <summary>
        /// Popula a base de dados com o nome <see cref="DatabaseName"/>.
        /// </summary>
        public void PopulateDatabase()
        {
            var funcionarioId = SelectUserTypeId(SelectUserTypeIdByUserTypeDescriptionCommand("funcionario"));
            var administradorId = SelectUserTypeId(SelectUserTypeIdByUserTypeDescriptionCommand("administrador"));

            var users = new List<IUtilizador> {
                new Funcionario("João", "Ferreira", null, "jferreira", "jfonseca", "jferreira@imovcelos.pt"),
                new Funcionario("Sónia", "Gomes", null, "sgomes", "sgomes", "sgomes@imovcelos.pt"),
                new Administrador("António Fonseca", "afonseca", "afonseca", "afonseca@imovcelos.pt")
            };

            var r1 = PopulateUserTypeTable();
            var r2 = PopulateUserTable(PopulateUserTableCommand(users));

            // TODO: error handling, make sure each command returns the appropriate result (number of rows affected?)

            //return NoCommandExecutionErrors(r1, r2);
        }

        // TODO: refactor
        private static int PopulateUserTable(IDbCommand command) => Convert.ToInt32(command.ExecuteNonQuery());

        // TODO: refactor
        private static int SelectUserTypeId(IDbCommand command) => Convert.ToInt32(command.ExecuteScalar());

        /// <summary>
        /// Retorna o comando que lê o UserTypeId do UserType com um determinado UserTypeDescription.
        /// </summary>
        private MySqlCommand SelectUserTypeIdByUserTypeDescriptionCommand(string userTypeDescription) => new MySqlCommand(
            $"SELECT `UserTypeId` FROM `{DatabaseName}`.`UserType` WHERE `UserTypeDescription` = '{userTypeDescription}';", _con);

        private MySqlCommand PopulateUserTableCommand(IEnumerable<IUtilizador> users) =>
            new MySqlCommand($@"INSERT INTO `{DatabaseName}`.`User` (`Username`, `Email`, `PasswordHash`, `UserTypeId`) VALUES {CreateUserRows(users)};", _con);

        private static string CreateUserRows(IEnumerable<IUtilizador> users)
        {
            var userRows = new List<string>();
            userRows.AddRange(users.Select(CreateUserRow));
            return string.Join(",", userRows);
        }

        /// <summary>
        /// Cria uma string que representa um valor de User a ser inserido na tabela User.
        /// </summary>
        /// <example>('jfonseca','jfonseca@foo.com','passwordsecreta','1')</example>
        private static string CreateUserRow(IUtilizador user) => string.Join(",", new List<string> { "(", user.Username , user.Email.Address, user.PasswordHash, user.TypeDescriptor, ")" });

        private int PopulateUserTypeTable() => Convert.ToInt32(PopulateUserTypeTableCommand.ExecuteNonQuery());

        private MySqlCommand PopulateUserTypeTableCommand => new MySqlCommand($"INSERT INTO `{DatabaseName}`.`UserType` (`UserTypeDescription`) VALUES ('funcionario'), ('administrador'), ('estudante');", _con);

        #endregion

        /// <summary>
        /// Faz a autenticação de um utilizador. 
        /// </summary>
        /// <param name="username">Username do utilizador</param>
        /// <param name="password">Password do utilizador</param>
        /// <returns></returns>
        public string ValidUser(string username, string password)
        {
            var command = SelectPasswordHashAndUserTypeDescriptionByUsernameCommand(username);
            //TODO: refactor
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

        /// <summary>
        /// Retorna o comando que lê a PasswordHash e o UserTypeDescription de um determinado User pelo seu Username.
        /// </summary>
        /// <param name="username">Username do utilizador</param>
        /// <returns></returns>
        private MySqlCommand SelectPasswordHashAndUserTypeDescriptionByUsernameCommand(string username) =>
            new MySqlCommand($"SELECT PasswordHash, UserTypeDescription FROM User NATURAL JOIN UserType WHERE Username = {username}", _con);

        #endregion
    }

    [Serializable]
    internal class IncorrectNumberOfAffectedRows : Exception
    {
        private readonly int _actualAffectedRows;
        private readonly int _expectedAffectedRows;

        public IncorrectNumberOfAffectedRows(int actualAffectedRows, int expectedAffectedRows)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        public IncorrectNumberOfAffectedRows(string message, int actualAffectedRows, int expectedAffectedRows) : base(message)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        public IncorrectNumberOfAffectedRows(string message, Exception innerException, int actualAffectedRows, int expectedAffectedRows) : base(message, innerException)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        protected IncorrectNumberOfAffectedRows(SerializationInfo info, StreamingContext context, int actualAffectedRows, int expectedAffectedRows) : base(info, context)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        public override string Message => $"Expected to have effected {_expectedAffectedRows} rows but affected {_actualAffectedRows}";
    }

}

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

        #region DropDatabase

        /// <summary>
        ///     Apaga a base de dados com o nome <see cref="DatabaseName" />.
        /// </summary>
        public void DropDatabase()
        {
            DropDatabaseCommand.ExecuteNonQuery();
        }

        /// <summary>
        ///     Retorna o comando que apaga a base de dados com o nome <see cref="DatabaseName" />.
        /// </summary>
        private MySqlCommand DropDatabaseCommand => new MySqlCommand($"DROP DATABASE IF EXISTS `{DatabaseName}`;", _con)
            ;

        #endregion

        /// <summary>
        ///     Cria a base de dados <see cref="DatabaseName" /> e as tabelas necessárias;
        /// </summary>
        // TODO: rename to something better, maybe SetupDatabase
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
            }
        }

        #region CreateDatabase

        /// <summary>
        ///     Cria a base de dados com o nome <see cref="DatabaseName" />.
        /// </summary>
        private void CreateDatabase()
        {
            const int expectedAffectedRows = 1;
            var affectedRows = CreateDatabaseCommand.ExecuteNonQuery();
            if (affectedRows != expectedAffectedRows)
                throw new IncorrectNumberOfAffectedRows(affectedRows, expectedAffectedRows);
        }

        /// <summary>
        ///     Retorna o comando que cria a base de dados com o nome <see cref="DatabaseName" />.
        /// </summary>
        private MySqlCommand CreateDatabaseCommand
            => new MySqlCommand($"CREATE DATABASE IF NOT EXISTS `{DatabaseName}`;", _con);

        #endregion

        #region CreateUserTypeTable

        /// <summary>
        ///     Cria a tabela UserType.
        /// </summary>
        private void CreateUserTypeTable()
        {
            const int expectedAffectedRows = 0;
            var affectedRows = CreateUserTypeTableCommand.ExecuteNonQuery();
            if (affectedRows != expectedAffectedRows)
                throw new IncorrectNumberOfAffectedRows(affectedRows, expectedAffectedRows);
        }

        /// <summary>
        ///     Retorna o comando que cria a tabela UserType.
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
        ///     Cria a tabela User.
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
        ///     Retorna o comando que cria a tabela User.
        /// </summary>
        private MySqlCommand CreateUserTableCommand
            =>
                new MySqlCommand(
                    $@"CREATE TABLE IF NOT EXISTS `{DatabaseName}`.`User` (
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
        
        // TODO: refactor
        //public int PopulateUserTable(IEnumerable<IUtilizador> users) => PopulateUserTableCommand(users).ExecuteNonQuery();

    //    private MySqlCommand PopulateUserTableCommand(IEnumerable<IUtilizador> users) =>
    //new MySqlCommand(
    //    $@"INSERT INTO `{DatabaseName}`.`User` (`Username`, `Email`, `PasswordHash`, `UserTypeId`) VALUES {CreateUserRows
    //        (users)};", _con);

        /*
        private MySqlCommand PopulateUserTableCommand(IEnumerable<IUtilizador> users) =>
            new MySqlCommand(
                $@"INSERT INTO `{DatabaseName}`.`User` (`Username`, `Email`, `PasswordHash`, `UserTypeId`) VALUES {CreateUserRows
                    (users)};", _con);

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
         */

        public int PopulateUserTypeTable(IEnumerable<string> userTypes) => Convert.ToInt32(PopulateUserTypeTableCommand(userTypes).ExecuteNonQuery());

        private MySqlCommand PopulateUserTypeTableCommand(IEnumerable<string> userTypes)
            =>
                new MySqlCommand(
                    $"INSERT INTO `{DatabaseName}`.`UserType` (`UserTypeDescription`) VALUES {GenerateUserTypes(userTypes)};",
                    _con);

        private string GenerateUserTypes(IEnumerable<string> userTypes) => string.Join(",", userTypes.Select(user => "('" + user + "')").ToList());

        #endregion

        public string GetUserUserTypeDescription(string username) => SelectUserTypeDescriptionByUsernameCommand(username).ExecuteScalar() as string;

        /// <summary>
        ///     Retorna o comando que lê a PasswordHash e o UserTypeDescription de um determinado User pelo seu Username.
        /// </summary>
        /// <param name="username">Username do utilizador</param>
        /// <returns></returns>
        private MySqlCommand SelectUserTypeDescriptionByUsernameCommand(string username) =>
            new MySqlCommand(
                $"SELECT UserTypeDescription FROM `{DatabaseName}`.`User` NATURAL JOIN `{DatabaseName}`.`UserType` WHERE Username = '{username}'",
                _con);

        public string GetUserPasswordHash(string username)
            => SelectUserPasswordHashByUsernameCommand(username).ExecuteScalar() as string;

        private MySqlCommand SelectUserPasswordHashByUsernameCommand(string username)
            => new MySqlCommand($"SELECT PasswordHash FROM `{DatabaseName}`.`User` WHERE Username = '{username}'", _con);

        #endregion
    }
}

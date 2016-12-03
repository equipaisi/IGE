using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using Middleware;

namespace Frontend
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // IGEApp app = new IGEApp();
            // app.InitializeDatabase();
            // app.Run(); // internamente chama application.run(new FormLogin());

            // DEBUG: create the database first (remover quando a aplicação estiver a ser usada)
            // Connect to the database
            try
            {
                var dbCon = new MySqlDb();
                dbCon.Open();

                dbCon.DropDatabase();
                MessageBox.Show($"Apagada a base de dados `ige`");
                
                //MessageBox.Show($"Criação da base de dados: {(dbCon.CreateDatabaseAndTables() ? "Sucesso" : "Insucesso")}");
                //MessageBox.Show($"Populating da base de dados: {(dbCon.PopulateDatabase() ? "Sucesso" : "Insucesso")}");
                Application.Run(new FormLogin(dbCon));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
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

//            IGEApp app = new IGEApp();
//            app.InitializeDatabase();
//            app.Run(); // internamente chama application.run(new FormLogin());

            // Connect to the database
            try
            {
                var dbCon = new MySqlDb();
                dbCon.Open();
                Application.Run(new FormLogin(dbCon));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

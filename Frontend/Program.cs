using System;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            try
            {
                Application.Run(new FormLogin());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

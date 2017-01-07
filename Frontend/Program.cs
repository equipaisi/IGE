using System;
using System.Windows.Forms;

namespace Frontend
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>  
        [STAThread]
        private static void Main()
        { 
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {         
                Application.Run(new Login());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Application.Run(new RegistarHabitacao());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

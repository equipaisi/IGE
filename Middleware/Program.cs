using System;

namespace Middleware
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var e = new Aluno("Adolfo", "Silva", null, new DateTime(1992, 11, 08), GeneroSexual.Homem, null);
            Console.WriteLine(e);
            Console.WriteLine();

            var a = new Funcionario("Oliver", "Mota", new[] { "Oliveira" }, "omota", "supersecreta182!", "omota@imovcelos.pt");
            //var a = new Funcionario("João", "Ferreira", new[] {"Oliveira", "Garcia"}, "jferreira", "password1234", "jferreira@imovcelos.pt");;
            Console.WriteLine(a.NomeCurto);
            Console.WriteLine(a.NomeCompleto);
            Console.WriteLine(string.Join(" ", a.NomesIntermedios));
            Console.WriteLine(a.DataDeCriacao);
            Console.WriteLine(a.Email);

            Console.WriteLine();
            
            var admin = new Administrador("José Fonseca", "jfonseca", "passwordsupersegura", "jfonseca@imovcelos.pt");
            Console.WriteLine(admin);

            Console.ReadKey();
            /*using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("IGE.Resources.cp.csv"))
            using (var reader = new StreamReader(stream))
            {
                string csv = reader.ReadToEnd();
                // do something with the CSV
                Console.WriteLine(csv);
            }*/
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
        }
    }
}

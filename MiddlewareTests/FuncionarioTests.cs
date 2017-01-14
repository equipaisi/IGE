using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;

namespace Middleware.Tests
{
    [TestClass()]
    public class FuncionarioTests
    {
        [TestMethod()]
        public void FuncionarioTest()
        {
            var func = new Funcionario("Oliver", "Mota", new[] { "Silva", "キャプテン翼" }, "omota", "supersecreta182!", "omota@imovcelos.pt");
            Assert.IsTrue(func != null);
            Assert.AreEqual(func.Username, "omota");
            Assert.AreEqual(func.Email, new MailAddress("omota@imovcelos.pt"));
            Assert.AreEqual(string.Join(" ", func.NomesIntermedios), "Silva キャプテン翼");
            Assert.AreEqual(func.NomeCurto, "Oliver Mota");
            Assert.AreEqual(func.NomeCompleto, "Oliver Silva キャプテン翼 Mota");
            Assert.AreEqual(func.PrimeiroNome, "Oliver");
            Assert.AreEqual(func.UltimoNome, "Mota");
        }

        [TestMethod()]
        public void FuncionarioNomeCompletoTest()
        {
            var f1 = new Funcionario("João", "Ferreira", null, "jferreira", "supersecreta182!", "omota@imovcelos.pt");
            Assert.AreEqual("João Ferreira", f1.NomeCompleto);
            f1.NomeCompleto = "João Castro Ferreira";
            Assert.AreEqual("João", f1.PrimeiroNome);
            Assert.AreEqual(new List<string> { "Castro" }, f1.NomesIntermedios.ToList());
            Assert.AreEqual("Ferreira", f1.UltimoNome);
            Assert.AreEqual("João Castro Ferreira", f1.NomeCompleto);
        }
    }
}
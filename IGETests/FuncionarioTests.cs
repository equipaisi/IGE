using Microsoft.VisualStudio.TestTools.UnitTesting;
using IGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IGE.Tests
{
    [TestClass()]
    public class FuncionarioTests
    {
        [TestMethod()]
        public void FuncionarioTest()
        {
            var func = new Funcionario("Oliver", "Mota", new []{"Silva", "キャプテン翼" }, "omota", "supersecreta182!", "omota@imovcelos.pt");
            Assert.IsTrue(func != null);
            Assert.AreEqual(func.Username, "omota");
            Assert.AreEqual(func.Email, new MailAddress("omota@imovcelos.pt"));
            Assert.AreEqual(string.Join(" ", func.NomesIntermedios), "Silva キャプテン翼");
            Assert.AreEqual(func.NomeCurto, "Oliver Mota");
            Assert.AreEqual(func.NomeCompleto, "Oliver Silva キャプテン翼 Mota");
            Assert.AreEqual(func.PrimeiroNome, "Oliver");
            Assert.AreEqual(func.UltimoNome, "Mota");
        }
    }
}
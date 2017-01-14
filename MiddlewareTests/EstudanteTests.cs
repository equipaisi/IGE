using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Middleware.Tests
{
    [TestClass()]
    public class EstudanteTests
    {
        [TestMethod()]
        public void EstudanteNomeTest()
        {
            var e1 = new Aluno("João", null, null, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João", e1.Nome);
            var e2 = new Aluno("João", "Ferreira", null, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Ferreira", e2.Nome);
            var e3 = new Aluno("João", "Ferreira", new []{"Garcia"}, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Garcia Ferreira", e3.Nome);
            var e4 = new Aluno("João", "Ferreira", new[] { "Garcia", "Hernandes" }, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Garcia Hernandes Ferreira", e4.Nome);
            var e5 = new Aluno("João", null, new[] { "Garcia", "Hernandes" }, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Garcia Hernandes", e5.Nome);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Tests
{
    [TestClass()]
    public class EstudanteTests
    {
        [TestMethod()]
        public void EstudanteNomeTest()
        {
            Aluno e1 = new Aluno("João", null, null, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João", e1.Nome);
            Aluno e2 = new Aluno("João", "Ferreira", null, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Ferreira", e2.Nome);
            Aluno e3 = new Aluno("João", "Ferreira", new []{"Garcia"}, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Garcia Ferreira", e3.Nome);
            Aluno e4 = new Aluno("João", "Ferreira", new[] { "Garcia", "Hernandes" }, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Garcia Hernandes Ferreira", e4.Nome);
            Aluno e5 = new Aluno("João", null, new[] { "Garcia", "Hernandes" }, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual("João Garcia Hernandes", e5.Nome);
        }
    }
}
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
            var e1 = new Aluno("João", null, null, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e1.Nome, "João");
            var e2 = new Aluno("João", "Ferreira", null, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e2.Nome, "João Ferreira");
            var e3 = new Aluno("João", "Ferreira", new []{"Garcia"}, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e3.Nome, "João Garcia Ferreira");
            var e4 = new Aluno("João", "Ferreira", new[] { "Garcia", "Hernandes" }, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e4.Nome, "João Garcia Hernandes Ferreira");
            var e5 = new Aluno("João", null, new[] { "Garcia", "Hernandes" }, new DateTime(1990, 07, 23), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e5.Nome, "João Garcia Hernandes");
        }

        /*
        [TestMethod()]
        public void IdadeTest()
        {
            var primeiroNome = "Joana";
            var ultimoNome = "Silva";
            var e1 = new Aluno(primeiroNome, ultimoNome, null, new DateTime(2004, 11, 10), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e1.Idade(), 12);
            var e2 = new Aluno(primeiroNome, ultimoNome, null, new DateTime(2004, 11, 11), GeneroSexual.Desconhecido, null);
            Assert.AreEqual(e2.Idade(), 11);
        }*/
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Middleware.Tests
{
    [TestClass()]
    public class UsernameTests
    {
        [TestMethod()]
        public void ValidTest()
        {
            Assert.AreEqual(Username.Valid("admin"), true);
            Assert.AreEqual(Username.Valid("a715"), true);
            Assert.AreEqual(Username.Valid(null), false);
            Assert.AreEqual(Username.Valid(""), false);
            Assert.AreEqual(Username.Valid(" "), false);
        }

        [TestMethod()]
        public void ComplexValidTest()
        {
            // Username tem que começar com uma letra e tem que ter um tamanho de pelo menos 8 caracteres.
            var preds = new List<Predicate<string>> {s => Char.IsLetter(s[0]), s => s.Length >= 8};

            Assert.AreEqual(Username.ComplexValid("administrador", preds), true);
            Assert.AreEqual(Username.ComplexValid("a715678g", preds), true);
            Assert.AreEqual(Username.ComplexValid("admin", preds), false);
            Assert.AreEqual(Username.ComplexValid("715ahasgasf", preds), false);
            Assert.AreEqual(Username.ComplexValid(null, preds), false);
            Assert.AreEqual(Username.ComplexValid("", preds), false);
            Assert.AreEqual(Username.ComplexValid(" ", preds), false);
        }
    }
}
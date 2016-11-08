﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using IGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGE.Tests
{
    [TestClass()]
    public class InstituicaoEnsinoTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(new InstituicaoEnsino()
            {
                Instituicao = "Instituto Politécnico do Cávado e do Ave",
                Curso = "Design Industrial",
                Ano = 2
            }.ToString(), "Instituto Politécnico do Cávado e do Ave - Design Industrial (2º ano)");
        }
    }
}
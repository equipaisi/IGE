using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Middleware.Tests
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
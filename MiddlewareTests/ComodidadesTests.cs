using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Middleware.Tests
{
    [TestClass()]
    public class ComodidadesTests
    {
        [TestMethod()]
        public void ComodidadesTest()
        {
            Assert.AreEqual(new Comodidades(false, false, false), default(Comodidades));
            Comodidades comodidades = new Comodidades(televisao: true, internet: true, servicoDeLimpeza: false);
            Assert.AreEqual(comodidades.Televisao, true);
            Assert.AreEqual(comodidades.Internet, true);
            Assert.AreEqual(comodidades.ServicoDeLimpeza, false);
            comodidades.ServicoDeLimpeza = true;
            Assert.AreEqual(comodidades.ServicoDeLimpeza, true);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Middleware.Tests
{
    [TestClass()]
    public class CamaTests
    {
        [TestMethod()]
        public void CamaCapacidadeTest()
        {
            Assert.AreEqual(new Cama(TipoCama.Single).Capacidade, 1);
            Assert.AreEqual(new Cama(TipoCama.Double).Capacidade, 2);
        }

        [TestMethod()]
        public void CamaToStringTest()
        {
            Assert.AreEqual(new Cama(TipoCama.Single).ToString(), "Tipo: Single");
            Assert.AreEqual(new Cama(TipoCama.Double).ToString(), "Tipo: Double");
        }
    }
}
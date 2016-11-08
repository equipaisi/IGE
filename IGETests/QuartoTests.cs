using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IGE.Tests
{
    [TestClass()]
    public class QuartoTests
    {
        [TestMethod()]
        public void QuartoNumeroDeCamasTest()
        {
            var quartoDuasCamasSingle = new Quarto(new[] {new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(quartoDuasCamasSingle.NumeroDeCamas, 2);
            var quartoCamaDupla = new Quarto(new[] {new Cama(TipoCama.Double)});
            Assert.AreEqual(quartoCamaDupla.NumeroDeCamas, 1);
            var q = new Quarto(new[] {new Cama(TipoCama.Double), new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(q.NumeroDeCamas, 3);
        }

        [TestMethod()]
        public void QuartoCapacidadeTest()
        {
            var quartoDuasCamasSingle = new Quarto(new[] {new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(quartoDuasCamasSingle.Capacidade, 2);
            var quartoCamaDupla = new Quarto(new[] {new Cama(TipoCama.Double)});
            Assert.AreEqual(quartoCamaDupla.Capacidade, 2);
            var q = new Quarto(new[] {new Cama(TipoCama.Double), new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(q.Capacidade, 4);
        }
    }
}
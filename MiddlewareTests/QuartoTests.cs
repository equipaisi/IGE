using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Middleware.Tests
{
    [TestClass()]
    public class QuartoTests
    {
        [TestMethod()]
        public void QuartoNumeroDeCamasTest()
        {
            Quarto quartoDuasCamasSingle = new Quarto(new[] {new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(quartoDuasCamasSingle.NumeroDeCamas, 2);
            Quarto quartoCamaDupla = new Quarto(new[] {new Cama(TipoCama.Double)});
            Assert.AreEqual(quartoCamaDupla.NumeroDeCamas, 1);
            Quarto q = new Quarto(new[] {new Cama(TipoCama.Double), new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(q.NumeroDeCamas, 3);
        }

        [TestMethod()]
        public void QuartoCapacidadeTest()
        {
            Quarto quartoDuasCamasSingle = new Quarto(new[] {new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(quartoDuasCamasSingle.Capacidade, 2);
            Quarto quartoCamaDupla = new Quarto(new[] {new Cama(TipoCama.Double)});
            Assert.AreEqual(quartoCamaDupla.Capacidade, 2);
            Quarto q = new Quarto(new[] {new Cama(TipoCama.Double), new Cama(TipoCama.Single), new Cama(TipoCama.Single)});
            Assert.AreEqual(q.Capacidade, 4);
        }
    }
}
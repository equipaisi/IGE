using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Middleware.Tests
{
    [TestClass()]
    public class HabitacaoTests
    {
        [TestMethod()]
        public void HabitacaoAssoalhadasMaiorIgualQuartosTest()
        {
            Habitacao habitacao = new Habitacao(new[]
            {
                new Quarto(new []{new Cama(TipoCama.Single)}),
                new Quarto(new []{new Cama(TipoCama.Single), new Cama(TipoCama.Single) })
            }, 3, 2, 120, 1999, new Morada("Rua das Flores", null));
            Assert.IsTrue(habitacao.NumeroDeAssoalhadas >= habitacao.NumeroDeQuartos);
        }

        [TestMethod]
        public void HabitacaoNumeroDeQuartosCamasECapacidadeTest()
        {
            Habitacao h = new Habitacao(new[]
            {
                new Quarto(new[] { new Cama(TipoCama.Single)}),
                new Quarto(new[] { new Cama(TipoCama.Double), new Cama(TipoCama.Single) })
            }, 3, 2, 120, 1999, new Morada("Rua das Flores", null));
            Assert.AreEqual(h.NumeroDeQuartos, 2);
            Assert.AreEqual(h.NumeroDeAssoalhadas, 3);
            Assert.AreEqual(h.NumeroDeCamas, 3);
            Assert.AreEqual(h.NumeroDeWcs, 2);
            Assert.AreEqual(h.Capacidade, 4);
        }

        [TestMethod()]
        public void HabitacaoTQuartosTest()
        {
            Habitacao h0 = new Habitacao(new IQuarto[0], 3, 2, 120, 1999, new Morada("Rua das Flores", null));
            Habitacao h1 = new Habitacao(new[] {new Quarto(new[] {new Cama(TipoCama.Single)})}, 3, 2, 120, 1999, new Morada("Rua das Flores", null));
            Habitacao h2 = new Habitacao(
                new[] {new Quarto(new[] {new Cama(TipoCama.Single)}), new Quarto(new[] {new Cama(TipoCama.Single), new Cama(TipoCama.Single)})}, 3, 2, 120, 1999, new Morada("Rua das Flores", null));
            Habitacao h3 =
                new Habitacao(
                    new[]
                    {new Quarto(new[] {new Cama(TipoCama.Single)}), new Quarto(new[] {new Cama(TipoCama.Single)}), new Quarto(new[] {new Cama(TipoCama.Single)})},
                    3, 2, 120, 1999, new Morada("Rua das Flores", null));
            Habitacao h4 =
                new Habitacao(
                    new[]
                    {
                        new Quarto(new[] {new Cama(TipoCama.Single)}), new Quarto(new[] {new Cama(TipoCama.Double)}), new Quarto(new[] {new Cama(TipoCama.Single)}),
                        new Quarto(new[] {new Cama(TipoCama.Single)})
                    }, 4, 2, 120, 1999, new Morada("Rua das Flores", null));
            Habitacao h5 =
                new Habitacao(
                    new[]
                    {
                        new Quarto(new[] {new Cama(TipoCama.Double)}), new Quarto(new[] {new Cama(TipoCama.Double)}), new Quarto(new[] {new Cama(TipoCama.Single)}),
                        new Quarto(new[] {new Cama(TipoCama.Single)}), new Quarto(new[] {new Cama(TipoCama.Single)})
                    }, 5, 2,
                    120, 1999, new Morada("Rua das Flores", null));
            Assert.AreEqual(h0.TQuartos, "T0");
            Assert.AreEqual(h1.TQuartos, "T1");
            Assert.AreEqual(h2.TQuartos, "T2");
            Assert.AreEqual(h3.TQuartos, "T3");
            Assert.AreEqual(h4.TQuartos, "T4");
            Assert.AreEqual(h5.TQuartos, "T5");
        }
    }
}   
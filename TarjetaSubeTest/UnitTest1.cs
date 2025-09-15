using TarjetaSube;
using NUnit.Framework;

namespace TarjetaSubeTest
{
    public class Tests
    {

        Tarjeta t;

        [SetUp]
        public void Setup()
        {
            t = new Tarjeta();
        }

        [Test]
        public void Test1()
        {
            t.Cargar(100);
            t.Pagar();
            Assert.AreEqual(t.Saldo, 50);
        }
    }
}
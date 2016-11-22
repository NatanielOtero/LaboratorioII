using System;
using Testeando;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// debe instanciar el obj estacionamiento y verifica si es null
        /// </summary>
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento est1 = new Estacionamiento();
            Assert.IsNotNull(est1);

        }
        [TestMethod]
        public void ListadoInstanciado()
        {
            Estacionamiento est2 = new Estacionamiento();
            Assert.IsNotNull(est2.vehiculos);

        }
    }
}

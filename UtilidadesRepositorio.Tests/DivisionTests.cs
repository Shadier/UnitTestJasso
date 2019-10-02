using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilidadesRepositorio.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_DivideEntreCero()
        {
            //Arrange o Planteamiento
            const int dividendo = 8;
            const int divisor = 0;

            //Act o Prueba
            var actual = Matematicas.Division(dividendo, divisor);

            //Assert => Excepción
        }
    }
}

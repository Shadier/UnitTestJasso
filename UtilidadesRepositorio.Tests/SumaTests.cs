using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilidadesRepositorio.Tests
{
    [TestClass]
    public class SumaTests
    {
        [TestMethod]
        public void Suma_ValoresValidos()
        {
            //Arrange o Planteamiento
            const int sumando1 = 3;
            const int sumando2 = 5;
            const int esperado = 8;

            //Act o Prueba
            var actual = Matematicas.Suma(sumando1, sumando2);

            //Assert o Afirmación
            Assert.AreEqual(esperado, actual);
        }
        
    }
}

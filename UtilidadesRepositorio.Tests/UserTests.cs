using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilidadesRepositorio.Tests
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public void addNewUser_CorrectData()
        {
            //Arrange o Planteamiento
            var user = new User();
            user.employeeID = 12314;
            user.FirstName = "Raúl";
            user.LastName = "Moreno";

            //Act o Prueba
            var actual = Assignments.addUser(user);

            //Assert o Afirmación
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void addNewUser_IncorrectName()
        {
            //Arrange o Planteamiento
            var user = new User();
            user.employeeID = 12314;
            user.FirstName = "Alex4";
            user.LastName = "Moreno";

            //Act o Prueba
            var actual = Assignments.addUser(user);

            //Assert o Afirmación
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void addNewUser_IncorrectLengthOfId()
        {
            //Arrange o Planteamiento
            var user = new User();
            user.employeeID = 114;
            user.FirstName = "Alex";
            user.LastName = "Moreno";

            //Act o Prueba
            var actual = Assignments.addUser(user);

            //Assert o Afirmación
            Assert.AreEqual(false, actual);
        }

    }
}

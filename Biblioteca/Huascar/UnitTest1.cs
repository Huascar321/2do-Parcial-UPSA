using System;
using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Huascar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Organizar
            Person Cliente = new Person("Nelson Mandela", 1000);
            double valoresperado = 1200;

            //Actuar
            Cliente.Save(200);
            double valorobtenido = Cliente.SaveMoney;

            //Afirmar
            Assert.AreEqual(valorobtenido, valoresperado);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Organizar
            Person Cliente = new Person("Nicolas Inmaduro", 1000);
            double valoresperado = 900;

            //Actuar
            Cliente.Spend(100);
            double valorobtenido = Cliente.SaveMoney;

            //Afirmar
            Assert.AreEqual(valorobtenido, valoresperado);
        }
    }
}

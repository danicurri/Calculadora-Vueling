﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraIntegrationTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestMethod()]
        public void DivisionTest()
        {
            Assert.IsTrue(iCalculadora.Division(6, 3) ==2);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(2, 3) == 6);
        }

        [TestMethod()]
        public void RestaTest()
        {
            int expected = 1;
            int actual = iCalculadora.Resta(3, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumaTest()
        {
            Assert.IsTrue(iCalculadora.Suma(2, 2) ==4);
        }
    }
}
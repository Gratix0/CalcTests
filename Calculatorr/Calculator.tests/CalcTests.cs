using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]

        public void Sum_10plus10_20return()
        {
            // Arrage
            double a = 10, b = 10, expected = 20;
            // Act
            Calculatorr.Calculator calculatorr = new Calculatorr.Calculator();
            double actual = calculatorr.Sum(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Diff_20min10_10return()
        {
            // Arrage
            double a = 20, b = 10, expected = 10;
            // Act
            Calculatorr.Calculator calculatorr = new Calculatorr.Calculator();
            double actual = calculatorr.Diff(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void umnosh_2X2_4return()
        {
            // Arrage
            double a = 2, b = 2, expected = 4;
            // Act
            Calculatorr.Calculator calculatorr = new Calculatorr.Calculator();
            double actual = calculatorr.Umnosh(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Delen_4del2_2return()
        {
            // Arrage
            double a = 4, b = 2, expected = 2;
            // Act
            Calculatorr.Calculator calculatorr = new Calculatorr.Calculator();
            double actual = calculatorr.Delenie(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

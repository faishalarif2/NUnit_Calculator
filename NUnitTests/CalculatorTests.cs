
using NUnit;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnit.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void UserTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual("Faishal Arif", cal.User("Faishal Arif"));
        }

        [TestMethod()]
        public void AdditionTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(50, cal.Addition(25, 25));
        }

        [TestMethod()]
        public void SubstractionTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(40, cal.Substraction(50, 10));
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(30, cal.Multiplication(6, 5));
        }
    }
}
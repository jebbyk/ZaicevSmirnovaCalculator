using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calculator.twoOperandsFunctionality;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    class ArithMeanCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 1.5)]
        [TestCase(1, -1, 0)]
        public void ArithMeanTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ArithMeanCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

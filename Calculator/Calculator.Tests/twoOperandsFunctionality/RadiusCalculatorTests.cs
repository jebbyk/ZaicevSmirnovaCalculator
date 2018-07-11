using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    class RadiusCalculatorTests
    {
        [TestCase(1, 1, 1.414)]
        [TestCase(3, 3, 4.243)]
        [TestCase(5, 5, 7.071)]
        public void RadiusTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new RadiusCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

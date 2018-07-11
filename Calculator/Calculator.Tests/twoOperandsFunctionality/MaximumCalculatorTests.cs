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
    class MaximumCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(2, -1, 2)]
        public void MaximumTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaximumCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

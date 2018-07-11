using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    class TenPowerCalculatorTest
    {
        [TestCase(1, 10)]
        [TestCase(-1, 0.1)]
        [TestCase(2, 100)]
        [TestCase(0, 1)]
        public void TenPowerTest(double firstValue, double expected)
        {
            var calculator = new TenPowerCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

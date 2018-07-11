using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    class NegativeCalculatorTest
    {
        [TestCase(-1, 1)]
        [TestCase(5, -5)]
        [TestCase(0, 0)]
        public void NegativeTest(double firstValue, double expected)
        {
            var calculator = new NegativeCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

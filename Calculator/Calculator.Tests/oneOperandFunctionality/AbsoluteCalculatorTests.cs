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
    public class AbsoluteCalculatorTests
    {
        [TestCase(-1, 1)]
        [TestCase(-5, 5)]
        [TestCase(-7, 7)]
        public void AbsolutetTest(double firstValue, double expected)
        {
            var calculator = new AbsoluteCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

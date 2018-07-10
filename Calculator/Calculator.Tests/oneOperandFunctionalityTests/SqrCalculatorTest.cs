using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calculator.oneOperandFunctionality;

namespace Calculator.Tests.oneOperandFunctionalityTests
{
    [TestFixture]
    public class SquareCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(30, 900)]
        [TestCase(60, 3600)]
        public void SquareTest(double firstValue, double expected)
        {
            var calculator = new SquareCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calculator.oneOperandFunctionality;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    public class CosinusCalculatorTest
    {
        [TestCase(0, 1)]
        [TestCase(30, 0.154)]
        [TestCase(60, -0.952)]
        public void CosinusTest(double firstValue, double expected)
        {
            var calculator = new CosinusCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult,0.001);
        }
    }
}

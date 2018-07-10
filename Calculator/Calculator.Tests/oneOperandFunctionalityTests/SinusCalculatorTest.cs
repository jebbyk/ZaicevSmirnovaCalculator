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
    public class SinusCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(30, -0.988)]
        [TestCase(60, -0.305)]
        public void SinusTest(double firstValue, double expected)
        {
            var calculator = new SinusCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
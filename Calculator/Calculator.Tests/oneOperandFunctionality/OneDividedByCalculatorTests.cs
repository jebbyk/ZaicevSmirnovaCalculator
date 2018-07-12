using System;
using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    public class OneDividedByCalculatorTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        public void OneDividedByTest(double firstValue, double expected)
        {
            var calculator = new OneDividedByCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new OneDividedByCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}

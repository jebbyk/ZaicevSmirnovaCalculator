using System;
using NUnit.Framework;
using Calculator.oneOperandFunctionality;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    public class SqrtCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(900, 30)]
        [TestCase(3600, 60)]
        public void SqrtTest(double firstValue, double expected)
        {
            var calculator = new SqrtCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new SqrtCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));
        }
    }
}

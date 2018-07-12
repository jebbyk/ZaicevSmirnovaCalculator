using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    class TwoPowerCalculatorTest
    {
        [TestCase(1, 2)]
        [TestCase(-1, 1/2.0f)]
        [TestCase(0, 1)]
        public void TwoPowerTest(double firstValue, double expected)
        {
            var calculator = new TwoPowerCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    public class ExponentPowerCalculatorTests
    {
        [TestCase(1, 2.718)]
        [TestCase(2, 7.389)]
        [TestCase(3, 20.085)]
        public void ExponentPowerTest(double firstValue, double expected)
        {
            var calculator = new ExponentPowerCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

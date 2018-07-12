using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    class NatLnCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.69)]
        [TestCase(4, 1.39)]
        public void NatLnCalculatorTest(double firstValue, double expected)
        {
            var calculator = new NatLnCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}

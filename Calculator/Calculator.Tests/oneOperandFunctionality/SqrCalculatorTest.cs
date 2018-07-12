using NUnit.Framework;
using Calculator.oneOperandFunctionality;

namespace Calculator.Tests.oneOperandFunctionality
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

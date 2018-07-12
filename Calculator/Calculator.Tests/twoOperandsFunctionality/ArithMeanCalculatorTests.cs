using NUnit.Framework;
using Calculator.twoOperandsFunctionality;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    class ArithMeanCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 1.5)]
        [TestCase(1, -1, 0)]
        public void ArithMeanTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ArithmeticMeanCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

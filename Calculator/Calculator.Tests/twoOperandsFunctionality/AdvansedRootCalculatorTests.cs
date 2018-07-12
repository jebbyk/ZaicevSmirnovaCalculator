using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    public class AdvansedRootCalculatorTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(16, 2, 4)]
        [TestCase(16, 4, 2)]
        public void AdvansedRootTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AdvansedRootCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

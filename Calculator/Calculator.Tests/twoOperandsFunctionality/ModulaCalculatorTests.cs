using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{
    class ModulaCalculatorTests
    {
        [TestCase(5, 3, 2)]
        [TestCase(3, 2, 1)]
        [TestCase(7, 4, 3)]
        public void ModulaTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ModulaCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

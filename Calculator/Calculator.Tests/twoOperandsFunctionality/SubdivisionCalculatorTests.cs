using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    class SubdivisionCalculatortests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 2, 1)]
        [TestCase(4, 2, 2)]
        public void SubdivisionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SubstractionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

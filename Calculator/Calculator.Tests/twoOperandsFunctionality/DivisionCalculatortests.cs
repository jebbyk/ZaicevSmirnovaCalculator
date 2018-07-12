using System;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    class DivisionCalculatortests
    {
        [TestCase(0, 13, 0)]
        [TestCase(3, 2, 1.5)]
        [TestCase(4, 2, 2)]
        public void DivisionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }


        [Test]
        public void ExceptionTest()
        {
            var calculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}

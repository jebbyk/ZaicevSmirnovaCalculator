using System;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{  
    [TestFixture]
    public class GeometricMeanCalculatorTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(3, 6, 3)]
        [TestCase(10, 6, 4)]
        public void GeometricMeanTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new GeometricMeanCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new GeometricMeanCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-1,-1));
        }
    }
}

﻿using NUnit.Framework;
using Calculator.twoOperandsFunctionality;

namespace Calculator.Tests.twoOperandsFunctionality
{
    [TestFixture]
    class PowerCalculatorTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(0, 10, 0)]
        public void PowerTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new PowerCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calculator.twoOperandsFunctionality;

namespace Calculator.Tests.twoOperandsFunctionalityTests
{
    [TestFixture]
    public class AdditionCalculatorTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 3)]
        [TestCase(5, 4, 9)]
        public void AdditionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AddittionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

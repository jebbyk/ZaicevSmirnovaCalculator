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
    class MultiplyCalculatortests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 2, 6)]
        [TestCase(4, 2, 8)]
        public void MultiplyTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MultiplyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

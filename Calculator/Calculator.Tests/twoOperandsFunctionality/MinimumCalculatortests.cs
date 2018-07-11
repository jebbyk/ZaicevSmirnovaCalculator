using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
{
    class MinimumCalculatortests
    {
        [TestCase(3, 5, 3)]
        [TestCase(3, 2, 2)]
        [TestCase(-4, 2, -4)]
        public void MinimumTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinimumCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

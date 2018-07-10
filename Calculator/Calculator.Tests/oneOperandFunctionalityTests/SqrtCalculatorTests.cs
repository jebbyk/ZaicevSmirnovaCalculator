using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calculator.oneOperandFunctionality;

namespace Calculator.Tests.oneOperandFunctionalityTests
{
    [TestFixture]
    public class SqrtCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(900, 30)]
        [TestCase(3600, 60)]
        public void SqrtTest(double firstValue, double expected)
        {
            var calculator = new SqrtCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

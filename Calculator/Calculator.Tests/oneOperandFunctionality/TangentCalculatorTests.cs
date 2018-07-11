using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Calculator.oneOperandFunctionality;
using NUnit.Framework;


namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    class TangentCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(30, -6.405)]
        [TestCase(-30, 6.405)]
        public void TangentCalculatorTest(double firstValue, double expected)
        {
            var calculator = new TangentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

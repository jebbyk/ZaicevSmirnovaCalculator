using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    [TestFixture]
    public class ArctangentCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(30, 1.537)]
        [TestCase(60, 1.554)]
        public void ArctangentTest(double firstValue, double expected)
        {
            var calculator = new ArctangentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

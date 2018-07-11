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
    public class CatangentCalculatorTests
    {
        [TestCase(30, -0.156)]
        [TestCase(60, 3.125)]
        [TestCase(90, -0.501)]
        public void CatangentTest(double firstValue, double expected)
        {
            var calculator = new CatangentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

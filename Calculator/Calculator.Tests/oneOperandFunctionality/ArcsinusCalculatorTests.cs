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
    class ArcsinusCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(0.5, 0.523)]
        [TestCase(0.9, 1.120)]
        public void ArcsinusCalculatorTest(double firstValue, double expected)
        {
            var calculator = new ArcsinusCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

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
    public class SquareCalculatorTest
    {
        [Test]
        public void ZeroTest()
        {
            var calculator = new SquareCalculator();
            Assert.AreEqual(1, calculator.Calculate(0));
        }

        [Test]
        public void OneTest()
        {
            var calculator = new SquareCalculator();
            Assert.AreEqual(1, calculator.Calculate(1));
        }

        [Test]
        public void TwoTest()
        {
            var calculator = new SquareCalculator();
            Assert.AreEqual(4, calculator.Calculate(2));
        }
    }
}

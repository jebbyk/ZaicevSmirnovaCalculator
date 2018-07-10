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
        [Test]
        public void ZeroTest()
        {
            var calculator = new AddittionCalculator();
            Assert.AreEqual(0, calculator.Calculate(0, 0));
        }

        [Test]
        public void FirstFieldTest()
        {
            var calculator = new AddittionCalculator();
            Assert.AreEqual(1, calculator.Calculate(1, 0));
        }

        [Test]
        public void SecondFieldTest()
        {
            var calculator = new AddittionCalculator();
            Assert.AreEqual(1, calculator.Calculate(0, 1));
        }
    }
}

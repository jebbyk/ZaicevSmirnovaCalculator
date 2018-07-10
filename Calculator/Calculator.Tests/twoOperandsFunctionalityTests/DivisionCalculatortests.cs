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
    class DivisionCalculatortests
    {
        [Test]
        public void ZeroTest()
        {
            var calculator = new DivisionCalculator();
            Assert.AreEqual(0, calculator.Calculate(0, 1));
        }

        [Test]
        public void FirstFieldTest()
        {
            var calculator = new DivisionCalculator();
            Assert.AreEqual(2, calculator.Calculate(2, 1));
        }

        [Test]
        public void SecondFieldTest()
        {
            var calculator = new DivisionCalculator();
            Assert.AreEqual(0.5, calculator.Calculate(1, 2));
        }

        [Test]
        public void MinusTest()
        {
            var calculator = new DivisionCalculator();
            Assert.AreEqual(-0.5, calculator.Calculate(-1, 2));
        }
    }
}

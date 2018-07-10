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
        [Test]
        public void ZeroTest()
        {
            var calculator = new MultiplyCalculator();
            Assert.AreEqual(0, calculator.Calculate(0, 0));
        }

        [Test]
        public void FirstFieldTest()
        {
            var calculator = new MultiplyCalculator();
            Assert.AreEqual(2, calculator.Calculate(2, 1));
        }

        [Test]
        public void SecondFieldTest()
        {
            var calculator = new MultiplyCalculator();
            Assert.AreEqual(2, calculator.Calculate(1, 2));
        }

        [Test]
        public void MinusTest()
        {
            var calculator = new MultiplyCalculator();
            Assert.AreEqual(-2, calculator.Calculate(-1, 2));
        }
    }
}

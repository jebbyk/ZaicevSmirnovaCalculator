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
        [Test]
        public void Test1()
        {
            var calculator = new SqrtCalculator();
            Assert.AreEqual(4, calculator.Calculate(16));
        }

        [Test]
        public void Test2()
        {
            var calculator = new SqrtCalculator();
            Assert.AreEqual(2, calculator.Calculate(4));
        }

        [Test]
        public void TestOne()
        {
            var calculator = new SqrtCalculator();
            Assert.AreEqual(1, calculator.Calculate(1));
        }
    }
}

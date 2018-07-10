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
    public class SinusCalculatorTest
    {
        [Test]
        public void ZeroTest()
        {
            var calculator = new SinusCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
        }
    }
}
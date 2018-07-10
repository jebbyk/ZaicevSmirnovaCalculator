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
    public class CosinusCalculatorTest
    {
        [Test]
        public void OneTest()
        {
            var calculator = new CosinusCalculator();
            Assert.AreEqual(1, calculator.Calculate(1));
        }
    }
}

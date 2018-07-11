using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Tests.twoOperandsFunctionalityTests
{
    public class TwoOperndsFactoryTests
    {
        [TestCase("+", typeof(AddittionCalculator))]
        [TestCase("-", typeof(SubstractionCalculator))]
        [TestCase("*", typeof(MultiplyCalculator))]
        [TestCase("/", typeof(DivisionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsCalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}

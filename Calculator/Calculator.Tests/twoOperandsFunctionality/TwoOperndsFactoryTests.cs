using System;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.twoOperandsFunctionality
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

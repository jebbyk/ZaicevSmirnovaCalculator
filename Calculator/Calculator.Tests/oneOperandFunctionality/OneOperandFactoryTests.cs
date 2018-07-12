using System;
using Calculator.oneOperandFunctionality;
using NUnit.Framework;

namespace Calculator.Tests.oneOperandFunctionality
{
    class OneOperandFactoryTests
    {
        [TestCase("Sin", typeof(SinusCalculator))]
        [TestCase("Cos", typeof(CosinusCalculator))]
        [TestCase("Sqrt", typeof(SqrtCalculator))]
        [TestCase("Sqr", typeof(SquareCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsCalculatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}

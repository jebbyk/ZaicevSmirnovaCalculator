using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.oneOperandFunctionality;
using Calculator.twoOperandsFunctionality;
using NUnit.Framework;
using NUnit.Framework.Internal;

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

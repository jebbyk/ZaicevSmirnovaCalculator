using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    class OneDividedByCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            return 1/firstNumber;
        }
    }
}

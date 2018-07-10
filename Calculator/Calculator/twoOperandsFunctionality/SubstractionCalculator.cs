using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    class SubstractionCalculator : ItwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}

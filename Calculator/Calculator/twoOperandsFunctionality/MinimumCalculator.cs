using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    class MinimumCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return secondNumber;
            }
            else
            {
                return firstNumber;
            }
        }
    }
}

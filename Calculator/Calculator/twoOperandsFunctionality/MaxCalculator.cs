using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}

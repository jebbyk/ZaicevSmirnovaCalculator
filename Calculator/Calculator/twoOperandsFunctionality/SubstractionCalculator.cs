using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Substraction function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes two doubles
        /// <returns>
        /// Returns result of  substraction of second number from first number
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    public class MaximumCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Maximum function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// takes two doubles
        /// <returns>
        /// Returns number that more then other
        /// </returns>
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

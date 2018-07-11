using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    public class MinimumCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Minimum function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// takes two doubles
        /// <returns>
        /// returns number that is less then other
        /// </returns>
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

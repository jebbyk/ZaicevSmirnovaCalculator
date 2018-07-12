using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    public class AdvansedRootCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Advansed rooting function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes only numbers that more then 0
        /// <returns>
        /// Returns result of x^(1/y)
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, 1/secondNumber);
        }
    }
}

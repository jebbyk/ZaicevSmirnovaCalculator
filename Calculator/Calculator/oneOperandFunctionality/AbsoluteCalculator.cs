using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Absolute function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns a number from the module
        /// </returns>
        public double Calculate(double firstNumber)
        {
            if (firstNumber > 0)
                return firstNumber;
            else return -firstNumber;
        }
    }
}

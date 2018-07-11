using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    class ArccosinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Arccosinus function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from arccosinus
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Acos(firstNumber);
        }
    }
}

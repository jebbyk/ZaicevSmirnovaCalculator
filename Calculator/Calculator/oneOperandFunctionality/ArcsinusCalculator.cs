using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    public class ArcsinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Arcsinus function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from arcsinus
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Asin(firstNumber);
        }
    }
}

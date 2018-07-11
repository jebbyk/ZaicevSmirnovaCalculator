using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    public class TangentCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Tangent function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from tangent
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Tan(firstNumber);
        }
    }
}

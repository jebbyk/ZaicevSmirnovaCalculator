using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    public class CatangentCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Arctangent function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from arctangent
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return (Math.Cos(firstNumber)/Math.Sin(firstNumber));
        }
    }
}

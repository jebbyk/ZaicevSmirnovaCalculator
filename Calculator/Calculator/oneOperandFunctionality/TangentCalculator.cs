using System;

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

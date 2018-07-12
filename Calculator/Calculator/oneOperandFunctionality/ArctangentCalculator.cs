using System;

namespace Calculator.oneOperandFunctionality
{
    public class ArctangentCalculator : IOneArgumentCalculator
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
            return Math.Atan(firstNumber);
        }
    }
}

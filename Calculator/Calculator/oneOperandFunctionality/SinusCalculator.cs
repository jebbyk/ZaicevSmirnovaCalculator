using System;

namespace Calculator.oneOperandFunctionality
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Sinus function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from sinus
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Sin(firstNumber);
        }
    }
}

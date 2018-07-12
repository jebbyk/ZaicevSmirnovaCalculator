using System;

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

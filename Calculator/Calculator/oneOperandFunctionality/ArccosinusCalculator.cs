using System;

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

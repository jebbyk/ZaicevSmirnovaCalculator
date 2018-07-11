using System;

namespace Calculator.oneOperandFunctionality
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Cosinus function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from cosinus
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
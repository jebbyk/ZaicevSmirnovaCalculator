using System;

namespace Calculator.oneOperandFunctionality
{
    public class ExponentPowerCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Exponent function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the exponentiation of an exponent
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Pow(Math.E, firstNumber);
        }
    }
}

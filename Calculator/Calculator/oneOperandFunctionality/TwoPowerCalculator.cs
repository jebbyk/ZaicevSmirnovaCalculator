using System;

namespace Calculator.oneOperandFunctionality
{
    public class TwoPowerCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// TwoPower function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from the construction of 2 to the number entered
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Pow(2, firstNumber);
        }
    }
}

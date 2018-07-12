using System;

namespace Calculator.oneOperandFunctionality
{
    public class NatLnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// NatLn function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns a number from the natural logarithm
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Log(firstNumber);
        }
    }
}

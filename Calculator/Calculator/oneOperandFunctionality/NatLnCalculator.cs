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
            if (firstNumber <= 0)
            {
                return Math.Log(firstNumber);
            }
            else
            {
                throw new Exception("должно быть больше 0");
            }
        }
    }
}

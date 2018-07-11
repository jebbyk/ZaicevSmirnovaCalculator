using System;

namespace Calculator.oneOperandFunctionality
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Sqrt function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// the number under the root must be greater than zero
        /// <returns>
        /// Returns a number from the root
        /// </returns>
        public double Calculate(double firstNumber)
        {
            if (firstNumber < 0)
            {
                throw new Exception("Извлечение из отрицательного");
            }
            return Math.Sqrt(firstNumber);
        }
    }
}

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
            if (firstNumber > -1 && firstNumber < 1)
            {
                return Math.Asin(firstNumber);
            }
            else
            {
                throw new Exception("Значение от -1 до 1");
            }
        }
    }
}

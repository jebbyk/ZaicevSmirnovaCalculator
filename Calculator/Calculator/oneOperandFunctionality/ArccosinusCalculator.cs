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
            if (firstNumber > -1 && firstNumber < 1)
            {
                return Math.Acos(firstNumber);
            }
            else
            {
                throw new Exception("Значение от -1 до 1");
            }
        }
    }
}

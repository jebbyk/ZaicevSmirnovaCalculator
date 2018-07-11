using System;

namespace Calculator.twoOperandsFunctionality
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Division function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// check secondNumber
        /// if secondNumber is zero
        /// then error
        /// <returns>
        ///returns result division
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstNumber / secondNumber;
        }
    }
}
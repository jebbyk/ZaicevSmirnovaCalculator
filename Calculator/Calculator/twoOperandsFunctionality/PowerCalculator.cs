using System;

namespace Calculator.twoOperandsFunctionality
{
    public class PowerCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Power function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes two doubles 
        /// <returns>
        /// Returns result of exponentiation
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}

using System;

namespace Calculator.twoOperandsFunctionality
{
    public class RadiusCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Radius function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes two doubles
        /// <returns>
        /// Returns distance from zero point to (x,y)
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return Math.Sqrt(firstNumber * firstNumber + secondNumber * secondNumber);
        }
    }
}

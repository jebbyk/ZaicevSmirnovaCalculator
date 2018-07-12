using System;

namespace Calculator.twoOperandsFunctionality
{
    public class GeometricMeanCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Gemetrical mean function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// summ of two numvers must be more then zero
        /// <returns>
        /// returs geometrical mean of two numbers
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            if ((firstNumber + secondNumber) < 0)
            {
                throw new Exception("Извлечение из отрицательного");
            }
            return Math.Sqrt(firstNumber + secondNumber);
        }
    }
}

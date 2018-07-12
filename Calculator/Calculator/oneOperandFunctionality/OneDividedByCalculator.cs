using System;

namespace Calculator.oneOperandFunctionality
{
    public class OneDividedByCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// OneDividedBy function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// Takes one double. first number shoudn't be equals zero
        /// <returns>
        /// Returns a number from the division of 1 to the number entered
        /// </returns>
        public double Calculate(double firstNumber)
        {
            if (firstNumber == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1/firstNumber;
        }
    }
}

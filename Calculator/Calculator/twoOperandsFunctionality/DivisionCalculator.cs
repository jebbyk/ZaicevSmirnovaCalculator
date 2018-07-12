using System;

namespace Calculator.twoOperandsFunctionality
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Division function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes two doubles. Second number shoudn't be equals zero
        /// <returns>
        /// returns result of division od first number by second number
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
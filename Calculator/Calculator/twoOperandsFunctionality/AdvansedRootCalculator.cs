using System;

namespace Calculator.twoOperandsFunctionality
{
    public class AdvansedRootCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Advansed rooting function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes only numbers that more then 0
        /// <returns>
        /// Returns result of x^(1/y)
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber < 0)
            {
                throw new Exception("некоректный ввод");
                
            }
            else
            {
                if (secondNumber == 0)
                {
                    throw new Exception("бесконечная степень");
                }
                else
                {
                    return Math.Pow(firstNumber, 1 / secondNumber);
                }
            }
        }
    }
}

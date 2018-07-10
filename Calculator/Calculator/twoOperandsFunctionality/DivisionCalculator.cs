using System;

namespace Calculator.twoOperandsFunctionality
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
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
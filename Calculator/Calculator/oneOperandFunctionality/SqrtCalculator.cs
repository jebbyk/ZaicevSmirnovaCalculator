using System;

namespace Calculator.oneOperandFunctionality
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            if (firstNumber < 0)
            {
                throw new Exception("Извлечение из отрицательного");
            }
            return Math.Sqrt(firstNumber);
        }
    }
}

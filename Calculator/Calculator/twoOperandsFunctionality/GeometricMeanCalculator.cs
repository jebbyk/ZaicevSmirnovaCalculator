using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    public class GeometricMeanCalculator : ITwoArgumentsCalculator
    {
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

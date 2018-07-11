using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    public class OneDividedByCalculator : IOneArgumentCalculator
    {
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

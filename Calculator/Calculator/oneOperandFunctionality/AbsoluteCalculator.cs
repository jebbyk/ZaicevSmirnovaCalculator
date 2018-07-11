using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            if (firstNumber > 0)
                return firstNumber;
            else return -firstNumber;
        }
    }
}

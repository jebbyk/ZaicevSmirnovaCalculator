using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
   static class TwoArgumentsCalculatorFactory
    {
       public static ItwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new AddittionCalculator();
                    break;
                case "-":
                    return new SubstractionCalculator();
                    break;
                case "*":
                    return new MultiplyCalculator();
                    break;
                case "/":
                    return new DivisionCalculator();
                    break;
                default:
                    throw new Exception("error");
            }
        }
    }
}

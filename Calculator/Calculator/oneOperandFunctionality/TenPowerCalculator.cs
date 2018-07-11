using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.oneOperandFunctionality
{
    public class TenPowerCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// TenPower function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number from the construction of 10 to the number entered
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return Math.Pow(10,firstNumber);
        }
    }
}

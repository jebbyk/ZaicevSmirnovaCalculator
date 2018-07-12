namespace Calculator.oneOperandFunctionality
{
    public class NegativeCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Negative function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns a negative first number
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return -(firstNumber);
        }
    }
}
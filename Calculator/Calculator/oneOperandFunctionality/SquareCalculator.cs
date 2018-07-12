namespace Calculator.oneOperandFunctionality
{
    public class SquareCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Square function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns the number squared
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return firstNumber * firstNumber;
        }
    }
}

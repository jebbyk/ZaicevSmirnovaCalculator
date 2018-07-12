namespace Calculator.oneOperandFunctionality
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Absolute function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns>
        /// Returns a number from the module
        /// </returns>
        public double Calculate(double firstNumber)
        {
            return firstNumber > 0 ? firstNumber : -firstNumber;
        }
    }
}

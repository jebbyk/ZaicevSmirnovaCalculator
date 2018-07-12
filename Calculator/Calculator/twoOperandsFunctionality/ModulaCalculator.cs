namespace Calculator.twoOperandsFunctionality
{
    public class ModulaCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///Modula function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes two doubles
        /// second number must bee more then zero
        /// <returns>
        /// returns modula from dividing first number by second number
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}

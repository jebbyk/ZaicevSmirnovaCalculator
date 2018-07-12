using System;

namespace Calculator.twoOperandsFunctionality
{
   public static class TwoArgumentsCalculatorFactory
    {
       public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new AddittionCalculator();
                case "-":
                    return new SubstractionCalculator();
                case "*":
                    return new MultiplyCalculator();
                case "/":
                    return new DivisionCalculator();
                case "Arith Mean":
                    return new ArithmeticMeanCalculator();
                case "x^y":
                    return new PowerCalculator();
                case "Max":
                    return new MaximumCalculator();
                case "Min":
                    return new MinimumCalculator();
                case "x^(1/y)":
                    return new AdvansedRootCalculator();
                case "x%y":
                    return new ModulaCalculator();
                case "Rad":
                    return new RadiusCalculator();
                case "Geom Mean":
                    return new GeometricMeanCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}

using System;

namespace Calculator.oneOperandFunctionality
{
    public static class OneArgumentsCalculatorFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new SinusCalculator();
                case "Cos":
                    return new CosinusCalculator();
                case "Sqrt":
                    return new SqrtCalculator();
                case "Sqr":
                    return new SquareCalculator();
                case "-x":
                    return new NegativeCalculator();
                case "10^x":
                    return new TenPowerCalculator();
                case "2^x":
                    return new TwoPowerCalculator();
                case "Tan":
                    return new TangentCalculator();
                case "Arcsin":
                    return new ArcsinusCalculator();
                case "Arccos":
                    return new ArccosinusCalculator();
                case "Ln":
                    return new NatLnCalculator();
                case "1/x":
                    return new OneDividedByCalculator();
                case "e^x":
                    return new ExponentPowerCalculator();
                case "Arctan":
                    return new ArctangentCalculator();
                case "|x|":
                    return  new AbsoluteCalculator();
                case "Ctan":
                    return new CatangentCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}

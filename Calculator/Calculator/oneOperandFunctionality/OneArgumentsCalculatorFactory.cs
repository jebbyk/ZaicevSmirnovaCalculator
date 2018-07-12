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
                    break;
                case "10^x":
                    return new TenPowerCalculator();
                    break;
                case "2^x":
                    return new TwoPowerCalculator();
                    break;
                case "Tan":
                    return new TangentCalculator();
                    break;
                case "Arcsin":
                    return new ArcsinusCalculator();
                    break;
                case "Arccos":
                    return new ArccosinusCalculator();
                    break;
                case "Ln":
                    return new NatLnCalculator();
                    break;
                case "1/x":
                    return new OneDividedByCalculator();
                    break;
                case "e^x":
                    return new ExponentPowerCalculator();
                    break;
                case "Arctan":
                    return new ArctangentCalculator();
                    break;
                case "|x|":
                    return  new AbsoluteCalculator();
                    break;
                case "Ctan":
                    return new CatangentCalculator();
                    break;
                default:
                    throw new Exception("error");
            }
        }
    }
}

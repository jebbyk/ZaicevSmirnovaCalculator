using System;
using System.Windows.Forms;
using Calculator.oneOperandFunctionality;
using Calculator.twoOperandsFunctionality;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void TwoArgumentsButtonClick(object sender, EventArgs e)
        {  
            Button clickedButton = (Button)sender;
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsCalculatorFactory.CreateCalculator(clickedButton.Text);
            double result = calculator.Calculate(number1, number2);
            ResultField.Text = result.ToString();
        }

       public void OneArgumentButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            double number = Convert.ToDouble(Number1Field.Text);
            IOneArgumentCalculator calculator = OneArgumentsCalculatorFactory.CreateCalculator(clickedButton.Text);
            double result = calculator.Calculate(number);
            ResultField.Text = result.ToString();
        }
    }
}
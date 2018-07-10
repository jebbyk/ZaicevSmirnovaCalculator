using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.twoOperandsFunctionality;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClick(object sender, EventArgs e)
        {  
            Button clickedButton = (Button)sender;
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            ItwoArgumentsCalculator calculator = TwoArgumentsCalculatorFactory.CreateCalculator(clickedButton.Text);
            double result = calculator.Calculate(number1, number2);
            ResultField.Text = result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            double result = 0;
            Button clickedButton = (Button)sender;
            switch (clickedButton.Text)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            ResultField.Text = result.ToString();
        }
    }
}

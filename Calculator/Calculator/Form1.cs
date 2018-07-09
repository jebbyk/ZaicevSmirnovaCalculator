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


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPlusClick(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            double result = number1 + number2;
            ResultField.Text = result.ToString();
        }

        private void buttonMinusClick(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            double result = number1 - number2;
            ResultField.Text = result.ToString();
        }

        private void buttonMultClick(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            double result = number1 * number2;
            ResultField.Text = result.ToString();
        }

        private void buttonDevideClick(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Number1Field.Text);
            double number2 = Convert.ToDouble(Number2Field.Text);
            double result = number1 / number2;
            ResultField.Text = result.ToString();
        }




        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

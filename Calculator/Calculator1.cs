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
    public partial class Calculator1 : Form
    {
        string input = string.Empty;        //Store user input
        string operators = string.Empty;     //first number
        string operand2 = string.Empty;     //second number
        char symbol;                     //char displayed
        double result = 0.0;                //results
        public Calculator1()
        {
            InitializeComponent();
        }
        private void Calculator1_Load(object sender, EventArgs e)
        {

        }

        #region Number Pad
        private void button08_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "8";
            this.Screen.Text += input;
        }

        private void button09_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "9";
            this.Screen.Text += input;
        }

        private void button04_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "4";
            this.Screen.Text += input;
        }

        private void button05_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "5";
            this.Screen.Text += input;
        }

        private void button06_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "6";
            this.Screen.Text += input;
        }

        private void button02_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "2";
            this.Screen.Text += input;
        }

        private void button07_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "7";
            this.Screen.Text += input;
        }

        private void button03_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "3";
            this.Screen.Text += input;
        }

        private void button01_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "1";
            this.Screen.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += "0";
            this.Screen.Text += input;
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            input += ".";
            this.Screen.Text += input;
        }
        #endregion

        #region Operators
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operators = input;
            symbol = '*';
            input = string.Empty;
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operators = input;
            symbol = '/';
            input = string.Empty;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operators = input;
            symbol = '+';
            input = string.Empty;
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operators = input;
            symbol = '-';
            input = string.Empty;
        }
        #endregion

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Screen.Text = "";
            this.input = string.Empty;
            this.operators = string.Empty;
            this.operand2 = string.Empty;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operators, out num1);
            double.TryParse(operand2, out num2);

            if (symbol == '+')
            {
                result = num1 + num2;
                Screen.Text = result.ToString();
            }
            else if (symbol == '-')
            {
                result = num1 - num2;
                Screen.Text = result.ToString();
            }
            else if (symbol == '*')
            {
                result = num1 * num2;
                Screen.Text = result.ToString();
            }
            else if (symbol == '/')
            {
                if (num2 != 0) //If not dividing by zero perform operation...
                {
                    result = num1 / num2;
                    Screen.Text = result.ToString();
                }
                else
                {
                    Screen.Text = "DIV/Zero!";  //Otherwise display exeption
                }

            } input += "=";
        }


    }
}

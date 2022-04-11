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
        string inputedValue = "0";
        string firstNumber = "0";
        string secondNumber = "0";
        string operators = "";
        private void display(string symbol)
        {
                kdDisplayArea.Text += symbol;   
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "1";
            }
            else
            {
                inputedValue = "1";
            }
            display("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "2";
            }
            else
            {
                inputedValue = "2";
            }
            display("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "3";
            }
            else
            {
                inputedValue = "3";
            }
            display("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "4";
            }
            else
            {
                inputedValue = "4";
            }
            display("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "5";
            }
            else
            {
                inputedValue = "5";
            }
            display("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "6";
            }
            else
            {
                inputedValue = "6";
            }
            display("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "7";
            }
            else
            {
                inputedValue = "7";
            }
            display("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "8";
            }
            else
            {
                inputedValue = "8";
            }
            display("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "9";
            }
            else
            {
                inputedValue = "9";
            }
            display("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            firstNumber = inputedValue;
            inputedValue = "0";
            operators = "+";
            display(" + ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstNumber = inputedValue;
            inputedValue = "0";
            operators = "-";
            display(" - ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = inputedValue;
            inputedValue = "0";
            operators = "*";
            display(" * ");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = inputedValue;
            inputedValue = "0";
            operators = "/";
            display(" / ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            secondNumber = inputedValue;
            if (operators != "")
            {
                double number1;
                double number2;
                double result;
                try
                {
                    number1 = Convert.ToDouble(firstNumber);
                    number2 = Convert.ToDouble(secondNumber);
                    switch (operators)
                    {
                        case "+":
                            {
                                kdDisplayArea.Text = "";
                                result = number1 + number2;
                                kdDisplayArea.Text = result.ToString();
                                inputedValue = result.ToString();
                                break;
                            }
                        case "-":
                            {
                                kdDisplayArea.Text = "";
                                result = number1 - number2;
                                kdDisplayArea.Text = result.ToString();
                                inputedValue = result.ToString();
                                break;
                            }
                        case "*":
                            {
                                kdDisplayArea.Text = "";
                                result = number1 * number2;
                                kdDisplayArea.Text = result.ToString();
                                inputedValue = result.ToString();
                                break;
                            }
                        case "/":
                            {
                                kdDisplayArea.Text = "";
                                if (number2 == 0)
                                {
                                    kdDisplayArea.Text = "Infinity";
                                }
                                else
                                {
                                    result = number1 / number2;
                                    kdDisplayArea.Text = result.ToString();
                                    inputedValue = result.ToString();
                                }
                                break;
                            }
                    }
                }
                catch
                {
                    kdDisplayArea.Text = "Math error";
                    inputedValue = "";
                    firstNumber = "";
                    secondNumber = "";
                    operators = "";
                }
            }
            else
            {
                kdDisplayArea.Text = "Use buttons :)";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (inputedValue != "0")
            {
                inputedValue += "0";
                display("0");
            }
            else
            {
                if (firstNumber == "0")
                {
                    inputedValue = "0";
                }
                else
                {
                    inputedValue += "0";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kdDisplayArea.Text = "";
            inputedValue = "";
            firstNumber = "";
            secondNumber = "";
            operators = "";
        }
    }
}

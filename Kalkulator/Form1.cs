using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        string function = "";
        double result = 0.0;
        string userInput = "";
        bool ifPreviouslyModified = false;
        bool equalsClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (function == "")
                first = userInput;
            ifPreviouslyModified = false;
            function = "/";
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (function == "")
                first = userInput;
            ifPreviouslyModified = false;
            function = "*";
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (function == "")
                first = userInput;
            ifPreviouslyModified = false;
            function = "-";
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (function == "")
                first = userInput;
            ifPreviouslyModified = false;
            function = "+";
            userInput = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (equalsClicked == false)
            {
                second = userInput;
                double firstNum, secondNum;
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);

                //Plus
                if (function == "+")
                {
                    function = "";
                    result = firstNum + secondNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = result.ToString();
                    ifPreviouslyModified = true;
                }

                //Minus
                else if (function == "-")
                {
                    function = "";
                    result = firstNum - secondNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = result.ToString();
                    ifPreviouslyModified = true;
                }

                //Puta
                else if (function == "*")
                {
                    function = "";
                    result = firstNum * secondNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = result.ToString();
                    ifPreviouslyModified = true;
                }

                //Podeljeno
                else if (function == "/")
                {
                    if (secondNum == 0)
                    {
                        calculatorDisplay.Text = "error";
                        userInput = "";
                    }

                    else
                    {
                        function = "";
                        result = firstNum / secondNum;
                        calculatorDisplay.Text = result.ToString();
                        userInput = result.ToString();
                        ifPreviouslyModified = true;
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {

            calculatorDisplay.Text += ",";
            userInput += ",";
        }

        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            calculatorDisplay.Text += 1 / Double.Parse(userInput);
            userInput = (1 / Double.Parse(userInput)).ToString();
            ifPreviouslyModified = true;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            calculatorDisplay.Text += Math.Pow(Double.Parse(userInput), 2);
            userInput = Math.Pow(Double.Parse(userInput), 2).ToString();
            ifPreviouslyModified = true;
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            calculatorDisplay.Text += Math.Sqrt(Double.Parse(userInput));
            userInput = Math.Sqrt(Double.Parse(userInput)).ToString();
            ifPreviouslyModified = true;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified) return;

            if (calculatorDisplay.Text.Length > 0)
                calculatorDisplay.Text = calculatorDisplay.Text.Remove(calculatorDisplay.Text.Length - 1, 1);

            if (calculatorDisplay.Text == "")
                calculatorDisplay.Text = "0";
            userInput = "";
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            userInput = "";
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }
    }
}
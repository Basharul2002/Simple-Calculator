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
        private double output = 0;
        private bool equal_button_click = false, ac_button_click = false, del_button_click = false;


        private List<string> numberList = new List<string>();
        private List<char> operatorList = new List<char>();


        public Form1()
        {
            InitializeComponent();
        }

        // Disable buttons
        private void ButtonDisable()
        {
            DisableButtons(zero_button, one_button, two_button, three_button, four_button, five_button, six_button, seven_button, eight_button, nine_button, point_button);
            DisableButtons(plus_button, minus_button, multiplication_button, division_button, c_button, equal_button);
        }


        // Enable buttons
        private void ButtonEnable()
        {
            EnableButtons(zero_button, one_button, two_button, three_button, four_button, five_button, six_button, seven_button, eight_button, nine_button, point_button);
            EnableButtons(plus_button, minus_button, multiplication_button, division_button, c_button, equal_button);
        }



        // Enable a group of buttons
        private void EnableButtons(params Button[] buttons)
        {
            foreach (Button button in buttons)
                button.Enabled = true;
        }



        // Disable a group of buttons
        private void DisableButtons(params Button[] buttons)
        {
            foreach (Button button in buttons)
                button.Enabled = false;
        }



        // Check if all numbers in a string can be parsed as double
        private bool AreAllNumbersDouble(string value)
        {
            return double.TryParse(value, out _);
        }



        // Handle equal button click
        private void equal_button_Click(object sender, EventArgs e)
        {
            // Check for syntax errors
            if (SyntaxError())
            {
                HandleError("Syntax Error", "[AC]   : Cancel");
                return;
            }

            // Split numbers and operators
            SplitNumbersAndOperators();

            double result = 0;

            // Check if all numbers are valid
            if (operatorList.Count > 0)
            {
                for (int i = 0; i < operatorList.Count; i++)
                {
                    if (!AreAllNumbersDouble(numberList[i]))
                    {
                        HandleError("Syntax Error", "[AC]   : Cancel");
                        return;
                    }

                    result = Calculator(result, double.Parse(numberList[i]), operatorList[i]);
                }
            }

            // Check for math errors
            if (double.IsNaN(result))
            {
                HandleError("Math Error", "[AC]   : Cancel");
                ButtonDisable();
                return;
            }

            // Round the result to 4 decimal places
            output = Math.Round(result, 4);
            // Display the result
            output_tb.Text = Environment.NewLine + result.ToString();
            equal_button_click = true;

            // Clear lists
            ListClear();
        }



        // Clear the number and operator lists
        private void ListClear()
        {
            numberList.Clear();
            operatorList.Clear();
        }



        // Handle errors by displaying a message, disabling buttons, and clearing the output
        private void HandleError(string errorType, string message)
        {
            error_warning_lvl.Text = $"{errorType} \n{message}";
            error_warning_lvl.Visible = true;
            ButtonDisable();
            output_tb.Text = "";
        }



        // Check for syntax errors in the input
        private bool SyntaxError()
        {
            return
            (
                input_tb.Text[0].ToString() == "*" ||
                input_tb.Text[0].ToString() == "/" ||
                IsOperator(input_tb.Text[input_tb.Text.Length - 1]) ||
                input_tb.Text.EndsWith(".")
            ) ||
            ContainsConsecutiveOperators();
        }



        // Check if the input contains consecutive operators
        private bool ContainsConsecutiveOperators()
        {
            for (int i = 0; i < input_tb.Text.Length - 1; i++)
            {
                if (IsOperator(input_tb.Text[i]) && IsOperator(input_tb.Text[i + 1]))
                    return true;
            }

            return false;
        }

        // Split numbers and operators from the input
        private void SplitNumbersAndOperators()
        {
            string input = input_tb.Text;
            string currentNumber = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                    currentNumber += c;

                else
                {
                    // Handle operators and validate currentNumber
                    HandleOperator(currentNumber, c);
                    currentNumber = "";
                }
            }

            // Handle the last number
            if (!string.IsNullOrEmpty(currentNumber))
                // Validate the last number
                HandleOperator(currentNumber, '\0'); // '\0' indicates the end of the string

        }

        // Handle operators and validate the current number
        private void HandleOperator(string currentNumber, char operatorChar)
        {

            // Validate the current number
            if (!string.IsNullOrWhiteSpace(currentNumber))
            {
                if (currentNumber.Count(c => c == '.') > 1)
                {
                    HandleError("Syntax Error", "[AC]   : Cancel");
                    output_tb.Text = "";
                    return;
                }


                // Parse the current number and add to the list
                numberList.Add(currentNumber);
            }


            // Handle the operator
            if (operatorChar != '\0')
            {
                // Add the operator to the list
                if (numberList.Count != operatorList.Count)
                    operatorList.Add('+');

                operatorList.Add(operatorChar);
            }
        }

        // Check if a character is an operator
        private bool IsOperator(char value)
        {
            return value == '+' || value == '-' || value == '*' || value == '/';
        }

        // Calculator logic to perform operations
        private double Calculator(double operand1, double operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand2 != 0 ? operand1 / operand2 : double.NaN;
                default:
                    throw new ArgumentException("Invalid operation: " + operation);
            }
        }


        // AC Button
        private void ac_button_Click(object sender, EventArgs e)
        {
            if (error_warning_lvl.Visible)
            {
                ButtonEnable();
                ListClear();
            }


            error_warning_lvl.Visible = false;
            input_tb.Clear();
            output_tb.Clear();
            ac_button_click = true;
        }

        // DEL Button
        private void del_button_Click(object sender, EventArgs e)
        {
            if (input_tb.Text.Length > 0)
            {
                input_tb.Text = input_tb.Text.Substring(0, input_tb.Text.Length - 1);
                output_tb.Text = "";
                del_button_click = true;
            }
        }

        // ALL Number, point, operation
        private void input_value_Click(object sender, EventArgs e)
        {
            Button clickButton = (Button)sender;

            if (!equal_button_click)
            {
                input_tb.Text += clickButton.Text;
            }

            else if (ac_button_click && !del_button_click && clickButton.Text != "+" && clickButton.Text != "-" && clickButton.Text != "/" && clickButton.Text != "*" && clickButton.Text != ".")
            {
                input_tb.Clear();
                output_tb.Clear();
                input_tb.Text = clickButton.Text;
                equal_button_click = false;
                ac_button_click = false;
            }

            else if (!ac_button_click && del_button_click)
            {
                input_tb.Text += clickButton.Text;
                equal_button_click = false;
                del_button_click = false;
                output_tb.Clear();
            }

            else
            {
                input_tb.Clear();
                output_tb.Clear();
                input_tb.Text = output + clickButton.Text;
                equal_button_click = false;
                del_button_click = false;
            }
        }

    }
}

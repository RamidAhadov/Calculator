using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Exceptions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "0";
            }
            else
            {
                tbxSecondNumber.Text += "0";
            }
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "1";
            }
            else
            {
                tbxSecondNumber.Text += "1";
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "2";
            }
            else
            {
                tbxSecondNumber.Text += "2";
            }
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "3";
            }
            else
            {
                tbxSecondNumber.Text += "3";
            }
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "4";
            }
            else
            {
                tbxSecondNumber.Text += "4";
            }
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "5";
            }
            else
            {
                tbxSecondNumber.Text += "5";
            }
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "6";
            }
            else
            {
                tbxSecondNumber.Text += "6";
            }
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "7";
            }
            else
            {
                tbxSecondNumber.Text += "7";
            }
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "8";
            }
            else
            {
                tbxSecondNumber.Text += "8";
            }
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxFirstNumber.Text += "9";
            }
            else
            {
                tbxSecondNumber.Text += "9";
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btnZero_Click(null,null);
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btnOne_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btnTwo_Click(null,null);
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btnThree_Click(null,null);
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btnFour_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btnFive_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btnSix_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btnSeven_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btnEight_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btnNine_Click(null, null);
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.C || e.KeyCode == Keys.Back)
            {
                btnDelete_Click(null,null);
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                btnPoint_Click(null,null);
            }
            if (e.KeyCode == Keys.Add)
            {
                btnPlus_Click(null,null);
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnMinus_Click(null,null);
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiply_Click(null,null);
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnDivide_Click(null,null);
            }
            if (e.KeyCode == Keys.P)
            {
                btnPercent_Click(null,null);
            }
            if (e.KeyCode == Keys.S)
            {
                btnSign_Click(null,null);
            }
            if (e.KeyCode == Keys.A)
            {
                btnEqual_Click(null,null);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxFirstNumber.Text = String.Empty;
            tbxSecondNumber.Text = String.Empty;
            tbxOperator.Text = String.Empty;
            tbxShowProcess.Text = String.Empty;
            lblFirstNumber.Text = String.Empty;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                if (tbxFirstNumber.Text.Contains("."))
                {
                    tbxFirstNumber.Text.Replace(".", "");
                    tbxFirstNumber.Text += ".";
                }
                else
                {
                    tbxFirstNumber.Text += ".";
                }
            }
            else
            {
                if (tbxSecondNumber.Text.Contains("."))
                {
                    int charPos = tbxSecondNumber.Text.IndexOf(".");
                    tbxSecondNumber.Text.Remove(charPos);
                    tbxSecondNumber.Text += ".";
                }
                else
                {
                    tbxSecondNumber.Text += ".";
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == String.Empty)
            {
                tbxOperator.Text = "+";
            }
            else
            {
                tbxOperator.Text = String.Empty;
                tbxOperator.Text += "+";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == String.Empty)
            {
                tbxOperator.Text = "-";
            }
            else
            {
                tbxOperator.Text = String.Empty;
                tbxOperator.Text += "-";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == String.Empty)
            {
                tbxOperator.Text = "x";
            }
            else
            {
                tbxOperator.Text = String.Empty;
                tbxOperator.Text += "x";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == String.Empty)
            {
                tbxOperator.Text = "/";
            }
            else
            {
                tbxOperator.Text = String.Empty;
                tbxOperator.Text += "/";
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == String.Empty)
            {
                tbxOperator.Text = "%";
            }
            else
            {
                tbxOperator.Text = String.Empty;
                tbxOperator.Text += "%";
            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (tbxOperator.Text == String.Empty)
            {
                if (!tbxFirstNumber.Text.Contains('-'))
                {
                    tbxFirstNumber.Text = "-" + tbxFirstNumber.Text;
                }
                else
                {
                    tbxFirstNumber.Text = tbxFirstNumber.Text.Replace("-", String.Empty);
                }
            }
            else
            {
                if (!tbxSecondNumber.Text.Contains('-'))
                {
                    tbxSecondNumber.Text = "-" + tbxSecondNumber.Text;
                }
                else
                {
                    tbxSecondNumber.Text = tbxSecondNumber.Text.Replace("-", String.Empty);
                }
            }
        }
        private void tbxFirstNumber_TextChanged(object sender, EventArgs e)
        {
            lblFirstNumber.Text = tbxFirstNumber.Text + " ";
            tbxShowProcess.Text = tbxFirstNumber.Text;
        }

        private void tbxOperator_TextChanged(object sender, EventArgs e)
        {
            lblFirstNumber.Text += tbxOperator.Text;
            tbxShowProcess.Text = String.Empty;
            try
            {
                if (tbxFirstNumber.Text == String.Empty)
                {
                    if (tbxOperator.Text != String.Empty)
                    {
                        throw new BlankBoxException("Please input first number");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                tbxOperator.Text = String.Empty;
                lblFirstNumber.Text = String.Empty;
            }
        }
        private void tbxSecondNumber_TextChanged(object sender, EventArgs e)
        {
            tbxShowProcess.Text = tbxSecondNumber.Text;
            try
            {
                if (tbxFirstNumber.Text == String.Empty)
                {
                    if (tbxSecondNumber.Text != String.Empty)
                    {
                        throw new BlankBoxException("Please input first number");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                tbxSecondNumber.Text = String.Empty;
                lblFirstNumber.Text = String.Empty;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;
            if (tbxOperator.Text == "-")
            {
                firstNumber = Convert.ToDouble(tbxFirstNumber.Text);
                secondNumber = Convert.ToDouble(tbxShowProcess.Text);
                result = firstNumber - secondNumber;
                tbxShowProcess.Text = result.ToString();
            }
            if (tbxOperator.Text == "+")
            {
                firstNumber = Convert.ToDouble(tbxFirstNumber.Text);
                secondNumber = Convert.ToDouble(tbxShowProcess.Text);
                result = firstNumber + secondNumber;
                tbxShowProcess.Text = result.ToString();
            }
            if (tbxOperator.Text == "x")
            {
                firstNumber = Convert.ToDouble(tbxFirstNumber.Text);
                secondNumber = Convert.ToDouble(tbxShowProcess.Text);
                result = firstNumber * secondNumber;
                tbxShowProcess.Text = result.ToString();
            }
            if (tbxOperator.Text == "/")
            {
                try
                {
                    if (tbxSecondNumber.Text == "0")
                    {
                        throw new DivideByZeroException("Error occurred! You cannot divide by zero!");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                firstNumber = Convert.ToDouble(tbxFirstNumber.Text);
                secondNumber = Convert.ToDouble(tbxShowProcess.Text);
                result = firstNumber / secondNumber;
                tbxShowProcess.Text = result.ToString();
            }
            if (tbxOperator.Text == "%")
            {
                firstNumber = Convert.ToDouble(tbxFirstNumber.Text);
                if (tbxSecondNumber.Text == String.Empty || tbxShowProcess.Text == String.Empty)
                {
                    result = firstNumber / 100;
                    tbxShowProcess.Text = result.ToString();
                }
                else if (tbxShowProcess.Text != String.Empty)
                {
                    int charPos = lblFirstNumber.Text.IndexOf(" ");
                    lblFirstNumber.Text.Remove(charPos, 2);
                    result = Convert.ToDouble(tbxShowProcess.Text);
                    result = result / 100;
                    tbxShowProcess.Text = result.ToString();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Chap12number7WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public string expressionOperatorString = "";
        public int number;
        public bool k;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "1";
            else
            {
                textNumbers.Text = "1";
                k = false;
            }
        }

        private void button2_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "2";
            else
            {
                textNumbers.Text = "2";
                k = false;
            }
        }

        private void button3_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "3";
            else
            {
                textNumbers.Text = "3";
                k = false;
            }
        }

        private void button4_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "4";
            else
            {
                textNumbers.Text = "4";
                k = false;
            }
        }

        private void button5_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "5";
            else
            {
                textNumbers.Text = "5";
                k = false;
            }
        }

        private void button6_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "6";
            else
            {
                textNumbers.Text = "6";
                k = false;
            }
        }

        private void button7_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "7";
            else
            {
                textNumbers.Text = "7";
                k = false;
            }
        }

        private void button8_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "8";
            else
            {
                textNumbers.Text = "8";
                k = false;
            }
        }

        private void button9_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "9";
            else
            {
                textNumbers.Text = "9";
                k = false;
            }
        }

        private void button0_Click(object d, EventArgs e)
        {
            if (k == false)
                textNumbers.Text += "0";
            else
            {
                textNumbers.Text = "0";
                k = false;
            }
        }

        private void buttonNeg_Click(object d, EventArgs e)
        {
            try
            {
                double temp = double.Parse(textNumbers.Text);
                temp = -1 * temp;
                textNumbers.Text = temp.ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error: Enter a number before hitting this button");
            }
        }

        private void buttonAdd_Click(object d, EventArgs e)
        {
            if (expressionOperatorString != "")
            {
                buttonEquals_Click(d, e);
                expressionOperatorString = "+";
                k = true;
            }
            else
            {
                expressionOperatorString = "+";
                number = int.Parse(textNumbers.Text);
                textNumbers.Text = "";
            }
        }

        private void buttonEquals_Click(object d, EventArgs e)
        {
            try
            {

                if (expressionOperatorString == "+")
                    number = number + int.Parse(textNumbers.Text);
                else
                    if (expressionOperatorString == "-")
                        number = number - int.Parse(textNumbers.Text);
                    else
                        if (expressionOperatorString == "x")
                            number = number * int.Parse(textNumbers.Text);
                        else
                            if (expressionOperatorString == "/")
                                number = number / int.Parse(textNumbers.Text);

                expressionOperatorString = "";
                textNumbers.Text = number.ToString();
            }
            catch (DivideByZeroException dze)
            {
                MessageBox.Show(dze.Message, "Problem!");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error");
            }
        }

        private void buttonSubtract_Click(object d, EventArgs e)
        {
            if (expressionOperatorString != "")
            {
                buttonEquals_Click(d, e);
                expressionOperatorString = "-";
                k = true;
            }
            else
            {
                expressionOperatorString = "-";
                number = int.Parse(textNumbers.Text);
                textNumbers.Text = "";
            }
        }

        private void buttonMultiply_Click(object d, EventArgs e)
        {
            if (expressionOperatorString != "")
            {
                buttonEquals_Click(d, e);
                expressionOperatorString = "x";
                k = true;
            }
            else
            {
                expressionOperatorString = "x";
                number = int.Parse(textNumbers.Text);
                textNumbers.Text = "";
            }
        }

        private void buttonDivide_Click(object d, EventArgs e)
        {
            if (expressionOperatorString != "")
            {
                buttonEquals_Click(d, e);
                expressionOperatorString = "/";
                k = true;
            }
            else
            {
                expressionOperatorString = "/";
                number = int.Parse(textNumbers.Text);
                textNumbers.Text = "";
            }
        }

        private void buttonClear_Click(object d, EventArgs e)
        {
            number = 0;
            textNumbers.Text = "";
            expressionOperatorString = "";
        }
    }
}

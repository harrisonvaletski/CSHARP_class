using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication25
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

        private void a_Click(object sender, EventArgs e)
        {
            double number_one,
                    number_two;

            number_one = GetFirstValue();
            number_two = GetSecondValue();

            if (number_one > 0 && number_two > 0)
            {
                r.ForeColor = Color.Yellow;
                r.Text = "Result = " + (number_one + number_two).ToString();
            }
        }
        private void m_Click(object sender, EventArgs e)
        {
            double number_one,
                   number_two;

            number_one = GetFirstValue();
            number_two = GetSecondValue();

            if (number_one > 0 && number_two > 0)
            {
                r.ForeColor = Color.Yellow;
                r.Text = "Result = " + (number_one * number_two).ToString();
            }

        }
        public double GetFirstValue()
        {
            double number_one;

            while (double.TryParse(x.Text, out number_one) == false)
            {
                r.ForeColor = Color.Red;
                r.Text = "Value must be numeric and > 0.";
                x.Text = "0";
                x.Focus();
            }
            return number_one;
        }
        public double GetSecondValue()
        {
            double number_two;
            while (double.TryParse(y.Text, out number_two) == false)
            {
                r.ForeColor = Color.Red;
                r.Text = "Value must be numeric and > 0.";
                y.Text = "0";
                y.Focus();
            }
            return number_two;
        }
    }
}

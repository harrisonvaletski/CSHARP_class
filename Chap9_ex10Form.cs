using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int guess;
        private int absolute;
        private int count;
        private Random number;

        public Form1()
        {
            InitializeComponent();
        }

        private void G_Click(object sender, EventArgs e)
        {
            while (int.TryParse(InputValue.Text, out guess) == false)
            {
                Message.Text = "No! Enter a number";
            }
            Message.Text = ""; Answer.Text = (++count).ToString();
            if (guess == absolute)
            {
                BackColor = Color.Yellow;
                Message.Text = "You Won!";
            }
            else
            {
                InputValue.Clear(); InputValue.Focus();
                if (guess > absolute)
                {
                    Message.Text = guess + " is way too much though, okay?";
                    BackColor = Color.Red;
                }
                else
                {
                    Message.Text = guess + " is way too small though, okay?";
                    BackColor = Color.Blue;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = new Random();
            absolute = number.Next(0, 101);
            count = 0;
        }

        private void R_Click(object sender, EventArgs e)
        {
            absolute = number.Next(0, 101);
            count = 0;
            BackColor = Color.LightCoral;
            InputValue.Clear();Answer.Text = ""; Message.Text = "";
            InputValue.Focus();
        }
    }
}

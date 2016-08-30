using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Today.ToShortDateString();
            theNewLabel.Text = 
                        theTextBox.Text + ", this is an event. "+date ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {           Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input Form", "Developed by Harrison Valetski\n\nVersion .09");        }

        private void processInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output;

            output = textBox1.Text + "\n" + textBox2.Text + "\n" +
                textBox3.Text;   MessageBox.Show(output, "Personal Data");
        }

        private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }
    }
}

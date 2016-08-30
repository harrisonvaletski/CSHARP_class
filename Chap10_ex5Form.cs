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

        private void button1_Click(object sender, EventArgs e)
        {

            if (product_selector.SelectedIndices.Count != 0)
            {
                if (QTY_comboBox.SelectedIndex > 0)
                {
                    label3.Text = "";
                    MessageBox.Show("  You have Ordered\n  \n\n" +
                            QTY_comboBox.SelectedItem +" "+ product_selector.SelectedItem +
                            " Bags\n\n" , "Confirmation Page");
                }
                else
                    label3.Text = "Make a selection!";
            }
            else
                label3.Text = "Please Order Something!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product_selector.ClearSelected();
            QTY_comboBox.Text = "";
            label3.Text = "";
        }
    }
}

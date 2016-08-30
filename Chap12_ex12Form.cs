using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CHap12_excercise1WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FrmNumberProcessor_Load(object sender, EventArgs e)
        {
            TextBoxValue1.Focus();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                ListBoxValue1.Items.Add(int.Parse(TextBoxValue1.Text));
                ListBoxValue2.Items.Add(int.Parse(TextBoxValue2.Text));
                ListBoxResult.Items.Add(int.Parse(TextBoxValue2.Text) * int.Parse(TextBoxValue1.Text));
                TextBoxValue1.Clear();
                TextBoxValue2.Clear();
                TextBoxValue1.Focus();
            }

            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show(exc.Message);
            }

            catch (System.FormatException exc)
            {
                MessageBox.Show(exc.Message, "Invalid number format");
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }

}


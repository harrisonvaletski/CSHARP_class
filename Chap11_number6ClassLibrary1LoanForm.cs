using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loans
{
    public partial class LoanForms : Form
    {
        public LoanForms()
        {
            InitializeComponent();
        }

        private void cmboTypeOfLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox.SelectedIndex == 1)
            {
                interest.Text = "7.5%";
                duration.Text = "4";
                MakeAutoStuffVisible(true);
                MakeHomeStuffVisible(false);
            }
            else
                if (combobox.SelectedIndex == 2)
                {
                    interest.Text = "5.5%";
                    duration.Text = "15";
                    MakeAutoStuffVisible(false);
                    MakeHomeStuffVisible(true);
                }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            err.Text = "";
            if (textbox2.Text == "")
            {
                err.Text = "Enter last name";
                textbox2.Focus();
            }
            if (textbox1.Text == "")
            {
                err.Text = "Enter first name";
                textbox1.Focus();
            }
            if (textbox3.Text == "")
            {
                err.Text = "Enter loan amount";
                textbox3.Focus();
            }
            if (combobox.SelectedIndex == 1)
            {
                // Code could be modified to make sure numeric values are entered prior to parsing. Better solution would involve TryParse( )
                Auto car = new Auto(textbox1.Text, textbox2.Text, .075,
                                                double.Parse(textbox3.Text),
                                                int.Parse(duration.Text), int.Parse(textbox6.Text),
                                                textbox5.Text, textbox4.Text);
                MessageBox.Show(car.ToString(), "Loan Details");
            }
            else
                if (combobox.SelectedIndex == 2)
                {
                    Home condo = new Home(textbox1.Text, textbox2.Text,
                                                    .055, double.Parse(textbox3.Text),
                                                    int.Parse(duration.Text), int.Parse(textbox10.Text),
                                                    int.Parse(textbox9.Text), textbox8.Text);
                    MessageBox.Show(condo.ToString(), "Loan Details");

                }
                else
                {
                    err.Text = "Select type of loan";
                    combobox.Focus();
                }


        }

        private void MakeAutoStuffVisible(bool vis)
        {
            err.Text = "";
            label10.Visible = vis;
            label13.Visible = vis;
            label12.Visible = vis;
            label11.Visible = vis;
            textbox7.Visible = vis;
            textbox4.Visible = vis;
            textbox5.Visible = vis;
            textbox6.Visible = vis;
            label8.Visible = vis;
        }

        private void MakeHomeStuffVisible(bool vis)
        {
            err.Text = "";
            label9.Visible = vis;
            label15.Visible = vis;
            label16.Visible = vis;
            label14.Visible = vis;
            textbox8.Visible = vis;
            textbox9.Visible = vis;
            textbox10.Visible = vis;
        }
    }
}

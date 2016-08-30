using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class BanksForm : Form
    {
        Check[] checkingCustomers;
        Save[] savingsCustomers;
        public BanksForm()
        {
            InitializeComponent();
        }

        private void BankingForm_Load(object sender, EventArgs e)
        {
            checkingCustomers = new Check[5];
            savingsCustomers = new Save[3];

            checkingCustomers[0] = new Check("York", "Susan", "1111234", true, true, true, 1000.00m, 3.00m);
            lstBxCheck.Items.Add(checkingCustomers[0].First + " " + checkingCustomers[0].Last);
            checkingCustomers[1] = new Check("Abbott", "Charles", "2343223", true, false, false, 500.00m, 5.00m);
            lstBxCheck.Items.Add(checkingCustomers[1].First + " " + checkingCustomers[1].Last);
            checkingCustomers[2] = new Check("Choo", "Chin", "2341237", true, true, true, 20.00m, 5.00m);
            lstBxCheck.Items.Add(checkingCustomers[2].First + " " + checkingCustomers[2].Last);
            checkingCustomers[3] = new Check("Jacobs", "Jennifer", "3451237", true, true, true, 120.00m, 5.00m);
            lstBxCheck.Items.Add(checkingCustomers[3].First + " " + checkingCustomers[3].Last);
            checkingCustomers[4] = new Check("White", "Keith", "8781237", true, true, true, 197.00m, 5.00m);
            lstBxCheck.Items.Add(checkingCustomers[4].First + " " + checkingCustomers[4].Last);

            savingsCustomers[0] = new Save("Mitchell", "Claude", "2221231", 0.015m, 1000.00m, 2500.00m);
            lstBxSave.Items.Add(savingsCustomers[0].First + " " + savingsCustomers[0].Last);
            savingsCustomers[1] = new Save("Keen", "Antonio", "1113419", 0.015m, 1000.00m, 1200.00m);
            lstBxSave.Items.Add(savingsCustomers[1].First + " " + savingsCustomers[1].Last);
            savingsCustomers[2] = new Save("Acker", "Jerome", "1687999", 0.015m, 1000.00m, 1234.00m);
            lstBxSave.Items.Add(savingsCustomers[2].First + " " + savingsCustomers[2].Last);
        }

        private void cmboTypeOfAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomers.Visible = true;
            if (cmboType.SelectedIndex == 0)
            {
                lstBxSave.Visible = true;
                lstBxCheck.Visible = false;
            }
            else
            {
                lstBxCheck.Visible = true;
                lstBxSave.Visible = false;
            }

        }

        private void lstBxSavings_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Save customer in savingsCustomers)
            {
                if ((customer.First + " " + customer.Last) == lstBxSave.SelectedItem.ToString())
                    MessageBox.Show(customer.ToString(), "Savings Account Customer");
            }
        }

        private void lstBxChecking_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Check customer in checkingCustomers)
            {
                if ((customer.First + " " + customer.Last) == lstBxCheck.SelectedItem.ToString())
                    MessageBox.Show(customer.ToString(), "Checking Account Customer");
            }

        }
    }
}

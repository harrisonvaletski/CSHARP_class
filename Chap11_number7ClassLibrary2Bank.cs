using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        private string Lname;
        private string Fname;
        private string Social;

        public BankAccount()
        {
        }
        public BankAccount(string lname, string fname,
                            string id)
        {
            Lname = lname;
            Fname = fname;
            Social = id;
        }

        public BankAccount(string id)
        {
            Social = id;

        }

        public string ID
        {
            get
            {
                return Social;
            }
        }

        public string Last
        {
            get
            {
                return Lname;
            }
            set
            {
                Lname = value;
            }
        }

        public string First
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + Fname + " " +
                        Lname + "\n" +
                    "Customer ID: " + Social + "\n";
        }
    }
}

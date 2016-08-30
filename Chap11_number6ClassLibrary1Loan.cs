using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loans
{
    public class Loan
    {
        private string LoanID;
        private string Fname;
        private string Lname;
        private double interest;
		private double Amt;
		private double term;
		
		public Loan()
		{
		}

		public Loan(double rate, double borrowed, double time)
		{
			interest = rate;
			Amt = borrowed;
			term = time;
		}

        public Loan(string first, string last,
                      double rate, double borrowed, double time)
        {
            Fname = first;
            Lname = last;
            interest = rate;
            Amt = borrowed;
            term = time;
        }


        public string loanNumber
        {
            get 
            { 
                return LoanID; 
            }
            set 
            { 
                LoanID = value; 
            }
        }

        public string CustomerFirst
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

        public string CustomerLast
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

		//Read-Only Properties
		public double InterestRate
		{
			get
			{
				return interest;
			}			
		}

        public double LoanAmount
		{
			get
			{
				return Amt;
			}			
		}

		public double TermYears
		{
			get
			{
				return term;
			}			
		}

        public override string ToString()
        {
            return "Customer:  " + Fname + " " +
                    Lname +
                    "\nLoan amount:  " + Amt.ToString("C") +
                    "\nInterest Rate:  " + interest.ToString("p2") +
                    "\nLoan Duration: " + term;
        }
	}
}

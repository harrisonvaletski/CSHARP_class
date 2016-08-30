using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Save : BankAccount
    {
        private decimal grade;
		private decimal empty;
		private decimal balance;
		
		public Save()
			: base()
		{
		}

		public Save(string Lname, string Fname, 
                                string id, decimal Grade, decimal Begin, 
                                decimal thebalance)
			: base(Lname, Fname, id)
		{
			grade = Grade;
			empty = Begin;
			balance = thebalance;
		}

		// Property grade
		public decimal Grade
		{
			get
			{
				return grade;
			}
			set
			{
				grade = value;
			}
		}

		// Property empty
		public decimal Empty
		{
			get
			{
				return empty;
			}
			set
			{
				empty = value;
			}
		}

		// Property balance
		public decimal Balance
		{
			get
			{
				return balance;
			}
			set
			{
				balance = value;
			}
		}

        public override string ToString()
        {
            return base.ToString() +
                "\nSavings Balance: " + balance.ToString("C") +
                "\nInterest Rate: " + grade.ToString("P2");
        }
	}
}


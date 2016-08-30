using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Check : BankAccount
        {
		private bool studentAccount;
		private bool MasterCard;
		private bool Bounce;
        private decimal Balance;
        private decimal Edit;
		
		public Check()
			: base()
		{
		}

		public Check(string lname, string fname, string id, bool student, 
                                bool Card, bool bounce, 
                                decimal bal, decimal file)
			: base(lname, fname, id)
		{
			studentAccount = student;
			MasterCard = Card;
			Bounce = bounce;
            Balance = bal;
            Edit = file;
 		}

        public Check(string lname, string fname, string id, 
                                decimal bal, decimal file, decimal grade)
            : base(lname, fname, id)
        {
            studentAccount = false;
            MasterCard = false;
            Bounce = false;
            Balance = bal;
            Edit = file;
        }
        

		public bool Students
		{
			get
			{
				return studentAccount;
			}
			set
			{
				studentAccount = value;
			}
		}

		public bool Debit
		{
			get
			{
				return MasterCard;
			}
			set
			{
				MasterCard = value;
			}
		}

        public decimal Credit
        {
            get
            {
                return Edit;
            }
            set
            {
                Edit = value;
            }
        }

        public decimal balance
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
            }
        }

		public bool fall
		{
			get
			{
				return Bounce;
			}
			set
			{
				Bounce = value;
			}
		}

        public override string ToString()
        {
            return base.ToString() +
                "\nChecking Balance: " + Balance.ToString("C") +
                "\nMonthly Service Charge: " + Edit.ToString("C");
        }
	}
}


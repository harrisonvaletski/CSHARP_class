using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loans
{
    class Home : Loan
    {
        private string address;
        private int year;
        private int sqFt;

        public Home()
            : base()
        {
        }

        public Home(double rate, double borrowed, double duration,
                            int age, int area, string street)
            : base(rate, borrowed, duration)
        {
            year = age;
            sqFt = area;
            address = street;
        }

        public Home(string first, string last, double rate, double borrowed, double duration,
                    int age, int area, string street)
            : base(first, last, rate, borrowed, duration)
        {
            year = age;
            sqFt = area;
            address = street;
        }


        //Property year
        public int YearBuilt
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        //Property for sqFt
        public int SqFootage
        {
            get
            {
                return sqFt;
            }
            set
            {
                sqFt = value;
            }
        }

        // Property for address
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nHome Loan Address: " + address;
        }
    }
}

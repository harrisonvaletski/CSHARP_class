using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loans
{
    class Auto : Loan
    {
        private int year;
        private string model;
        private string make;
        private string color;

        public Auto()
            : base()
        {
        }

        public Auto(double intRate, double prinBorrowed,
                        double duration, int yr, string mod,
                        string carMake)
            : base(intRate, prinBorrowed, duration)
        {
            year = yr;
            model = mod;
            make = carMake;
        }

        public Auto(string first, string last, double intRate, double prinBorrowed,
                double duration, int yr, string mod,
                string carMake)
            : base(first, last, intRate, prinBorrowed, duration)
        {
            year = yr;
            model = mod;
            make = carMake;
        }

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

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string AutoColor
        {
            get
            {
                return color;
            }
            set
            {
                make = color;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nType of Car: " +
                year + " " +
                color + " " + model;
        }
    }
}

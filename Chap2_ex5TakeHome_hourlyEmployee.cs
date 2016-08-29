using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class hourlyEmployee
    {
        int hoursForWeek;
        int wage;
        string fName;
        string lName;
        int id;
        


        public hourlyEmployee() {
        }

        public hourlyEmployee(int id, string fName, string lName, int wage, int hoursForWeek)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.wage = wage;
            this.hoursForWeek = hoursForWeek;
        }

        public double getIncome()
        {

            if (this.getHours() > 40) { double a = (this.getHours() - 40) * (this.getWage() * .5) + (this.getHours() * this.getWage()); return a; }
            else
            {
                double a = this.getHours() * this.getWage();
                return a;
            }
          
        }

        public int getHours()
        {
            return this.hoursForWeek;
        }
        public int getWage()
        {
            return this.wage;
        }

        public override string ToString()
        {


            string a ="eid: "+ this.id + "\nname: " + this.fName + this.lName + "\nrate: " + this.wage+"\nhours: "+this.hoursForWeek;
            
            return a;
        }
    }
}

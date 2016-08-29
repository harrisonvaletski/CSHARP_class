using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class SalariedEmployee
    {

        int salary;
        string fName;
        string lName;
        int id;


        public SalariedEmployee() {
        }

        public SalariedEmployee(int id, string fName, string lName, int salary)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.salary = salary;
        }
        public int getSalary()
        {
            return this.salary;
        }

        public override string ToString()
        {

            string a = "eid: "+this.id + "\nname: " + this.fName + this.lName + "\nsalary: " + this.salary;
            
            
            return a;
        }
    }
}

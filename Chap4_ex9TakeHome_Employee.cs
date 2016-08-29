using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hvaletskichapter4problem9
{
    class Employee
    {
        string name;
        int sales;

        Employee() {

    }
        public Employee(string a, string b)
        {
            name = a;
               sales= int.Parse(b);
        }

       
        public void Name(string inValue)
        {
            this.name = inValue;
        }
        public int Sales(string commision)
        {
            sales = int.Parse(commision);
            return sales;
        }
        public override string ToString()
        {
            string a = "Sales: "+sales+"\tEmployee: " + name + "\nCommission Earning: " + sales * .07;
            string b ="\n"+"Federal Tax: "+(sales*.18)/100+"\nSocial Security: "+(sales*.06)/100+"\nRetirement: "+(sales*.1)/100;
            string c = "\nSales - Taxes: "+sales+" - "+sales*.34+"\nTake Home Pay: "+(sales-sales*.34);
            return a+b+c;
        }
        
        //Include at least one mutator and one accessor method; provide properties for the other instance variables.

        //Use appropriate constants, design an object-oriented solution, and write constructors.

        //All employees receive 7% of the total sales.

        //Federal tax rate is 18%.

        //Retirement contribution is 10%.

        //Social Security tax rate is 6%.




    

    }
}

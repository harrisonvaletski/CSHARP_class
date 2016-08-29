using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Payroll
    {
        double federalTax = .18;
        double retirement = .1;
        double socialSecurity = .06;
        double overTime = 1.5;
        string type;
        double Taxes;
        public Payroll(){
            
        }
        public Payroll(SalariedEmployee a)
        {
            this.type = "Salaried";
            this.federalTax = a.getSalary() * federalTax;
            this.socialSecurity = a.getSalary() * socialSecurity;
            this.retirement = a.getSalary() * retirement;
            Taxes = this.federalTax + this.socialSecurity + this.retirement;

            string refOut = "Total Income: " + a.getSalary() + "\nFederal Tax Estimate: " + this.federalTax + "\nSocial Security Estimate: " + this.socialSecurity + "\nRetirement Estimate: " + this.retirement;
            Console.WriteLine(refOut);
        }

        public Payroll(hourlyEmployee a)
        {
            this.type = "hourly";
            this.federalTax = a.getIncome() * federalTax;
            this.socialSecurity = a.getIncome() * socialSecurity;
            this.retirement = a.getIncome() * retirement;
            Taxes = this.federalTax + this.socialSecurity + this.retirement;

            string refOut = "Total Income: " + a.getIncome() + "\nFederal Tax Estimate: " + this.federalTax + "\nSocial Security Estimate: " + this.socialSecurity + "\nRetirement Estimate: "+this.retirement;
            Console.WriteLine(refOut);
        

        }

        public double getTaxes()
        {
            return Taxes;
        }
        public override string ToString()
        {
            string a = "\nSo approximately "+Taxes+" will be collected";
            return a;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Employee
    {



        int employeeNumber;
        string name;
        string dateOfHire;
        string jobDescription;
        string department;
        int monthlySalary;




        public Employee()
        {

        }
            public Employee(int employeeNumber, string name, string dateOfHire, string jobDescription, string department, int monthlySalary){

                this.employeeNumber = employeeNumber;
                this.name = name;
                this.dateOfHire = dateOfHire;
                this.jobDescription = jobDescription;
                this.department = department;
                this.monthlySalary = monthlySalary;

            
            }
        
        public override string ToString(){
            string job = "\n\n\t"+"eid: "+employeeNumber+"\n\t"+"name: "+name+"\n\t"+"date of hire: "+dateOfHire+"\n\t"+"description: "+jobDescription+"\n\t"+"department: "+department+"\n\t"+"salary: "+monthlySalary;

            return job;
        }


    }

}

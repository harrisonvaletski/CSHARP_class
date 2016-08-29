using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hvaletskichapter4problem9
{
    class Program
    {
        static void Main(string[] args)
        {

            //calculate and print the take-home pay for a commissioned sales employee.

            //Write instance methods to calculate the commission income, federal and social security tax withholding amounts and the amount withheld for retirement.
            
            //Create a second class to test your design.

           // Allow the user to enter values for the name of the employee and the sales amount for the week in the second class.


            Console.WriteLine("How many sales have you had this month?");
            String sales = Console.ReadLine();
            Console.WriteLine("Whats your name?");
            String name = Console.ReadLine();
            Employee CommisionedEmployee = new Employee(name, sales);

            Console.Write(CommisionedEmployee.ToString());
            Console.Write("\nThank You");
            Console.ReadKey();
        }
    }
}

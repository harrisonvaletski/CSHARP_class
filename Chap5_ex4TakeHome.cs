using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program Calculates Take Home Pay for our Employees. We have only Salaried and Hourly Employees here, by the way. If you would like to continue using this application please indicate that you are either a 'Salaried' or 'Hourly' type employee now: ");
            string p = Console.ReadLine();
            if (p == "Salaried") {
                Console.Write("Now I need Some more information to continue. ");
                Console.WriteLine("What is your First Name?");
                String f = Console.ReadLine();
                Console.Write("What is your last Name?");
                String l = Console.ReadLine();
                Console.Write("What is your Employee Number?");
                int eid = int.Parse(Console.ReadLine());
                Console.Write("Please be cooperative and have patience with our new application. How much are you getting from all of this exactly?");
                int s = int.Parse(Console.ReadLine());
                SalariedEmployee u = new SalariedEmployee(eid, f, l, s);
                Console.WriteLine("Thank you for visiting! Please Verify the Information: " + u.ToString());
                
                Console.ReadKey();
                Payroll PokeBall = new Payroll(u);
                Console.Write("it looks like you'll have to pay approximately "+PokeBall.getTaxes()+" in taxes. Thank you for using this application. ");
                
            }
            else if (p == "Hourly")
            {
                Console.WriteLine("What is your First Name?");
                String f = Console.ReadLine();
                Console.Write("What is your last Name?");
                String l = Console.ReadLine();
                Console.Write("What is your Employee Number?");
                int eid = int.Parse(Console.ReadLine());
                Console.Write("In whole hours, how much time do you spend at the office lately?");
                int h = int.Parse(Console.ReadLine());
                Console.Write("May I ask what your pay rate is now?");
                int w = int.Parse(Console.ReadLine());
                hourlyEmployee m = new hourlyEmployee(eid,f,l,w,h);
                Console.WriteLine("Thank you for visiting! Please Verify the Information: " + m.ToString());
                
                Console.ReadKey();
                Payroll PokeBall = new Payroll(m);
                Console.WriteLine("it looks like you'll have to pay approximately "+PokeBall.getTaxes()+" in taxes. Thank you for using this application. ");
                
            } else { Console.Write("That is not a valid answer. Game Over."); }

            Console.ReadKey();
        }
    }
}

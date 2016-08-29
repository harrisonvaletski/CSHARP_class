using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("list of new employees");
            Employee Emily = new Employee(970439670,"Emily Davis","03/16/1991","Financier","Theology",650);
            String SayHi = Emily.ToString();
            Console.WriteLine(SayHi);



            Console.ReadKey();

        }
    }
}

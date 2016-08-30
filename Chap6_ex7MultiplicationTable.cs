using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            write a program that produces a multiplication table with 25 rows of computations. allow the user to input the first and last base values for the multiplication table.
             * Display a column in the table beginning with the first base inputted value. The last column should be the ending base value entered. 
             * The first row should be for 1 times the beginning base, 1 times the beginning base+1, through 1 times the ending base. The last row should be for 25 times the ending base value.
             * Base values can range from 2 through 8. Display an error message if an invalid base is entered. Display an aesthetically formatted multiplication table. An example of output produced with 2 and 8 are entered appears in figure 6-22.

            */

            System.Console.Write("Multiplication Computation\n\n\tinput the first and last values for the base values of the table.");


            int integerValue1,
                integerValue2;
            string beginValue = System.Console.ReadLine();
            if (int.TryParse(beginValue, out integerValue1) == false || integerValue1<2) {
                Console.Write("Ivalid");
                Console.WriteLine("Try again.");
                beginValue = Console.ReadLine();
            }
            Console.Write("First base value submitted successfully.");
            string endValue = System.Console.ReadLine();
            if (int.TryParse(endValue, out integerValue2) == false || integerValue2 > 8)
            {
                Console.Write("Ivalid");
                Console.WriteLine("Try again.");
                endValue = Console.ReadLine();
            }
            Console.WriteLine("Second base value submitted.");
            for (int j = 1; j < 26; j++)
            {
                Console.Write(j);
                for (int i = int.Parse(beginValue); i < int.Parse(endValue); i++)
                {


                    Console.Write("\t" + j*i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {

            //chapter six number 22
            //write a for loop to display every third number beginning with 10 and continueing through 100
            Console.Write("This is a program that displays every third number from ten\nPress any key to begin.");
            Console.ReadKey();





            for (int i = 10; i < 100; i++)
            {

                if ((i - 10) % 3 == 0) Console.Write(i + "\n");

            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static double Entering()
        {

            Console.Write("\tPlease enter the temperature in Farenheit:");
            String inputValue = Console.ReadLine();
            double b = double.Parse(inputValue);

            return b;
        }

        public static double Calculating(double b)
        {
            double toCelsius = ((5 / 9) * (b - 32));
            Console.WriteLine("We convert Fahrenheight to Celsius C=F-32(5/9)");
            return toCelsius; 
        }

        public static String Outputting(double a)
        {
            String because = "So in Celsius that would be: " + a;


            return because;
        }

        static void Main(string[] args)
        {
            double Fahrenheit = Entering();
            double floats = Calculating(Fahrenheit);

            Console.WriteLine(Outputting(floats));
            Console.ReadKey();
        }
    }
}

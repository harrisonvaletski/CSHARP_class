using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal M = .15m;
            decimal R = 52m;
            decimal T = 71m;

            Console.WriteLine("\n\nAmerican Apparel Retail Markup Item List:\n\n");

            Console.WriteLine("\tRuggy Shoes from (wholesale) {0:c}", R);
            Console.WriteLine("\tnow (retail) {0:c}", R+R*M);

            Console.WriteLine("\tTenoe Jacket from (wholesale) {0:c}", T);
            Console.Write("\tnow (retail) {0:c}", T+T*M);


            Console.ReadKey();




        }
    }
}

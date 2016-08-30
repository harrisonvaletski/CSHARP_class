using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperature = new int[4];
            int[] t = new int[4];
            //Array t will reference the same array 
            //as the temperature array
            t = temperature;
            string a ="Values stored in temperatures:", b = "Distinct Values : ";
            string inValue;
            for (int i = 0; i < temperature.Length; i++)
            {
                Console.Write("Enter temperature {0}: ", i + 1);
                a+=" "+temperature[i];
                inValue = Console.ReadLine();
                temperature[i] = int.Parse(inValue);

                if (!t.Contains((int.Parse(inValue))))
                {
                    t[i] = temperature[i];
                    b += " " + t[i];
                }
                if (int.TryParse(inValue, out temperature[i]) == false)
                    Console.WriteLine("Invalid data entered - " +
                                        "0 stored in array element");
            }
            
            
            /*for (int j = 0; j < t.Length; j++)
            {
                if (temperature[j] != (int.Parse(inValue)))
                {
                    t[j] = temperature[j];
                    b += " " + t[j];
                }
            }*/
            Console.Write(a+"\n"+b);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12_number2ConsoleApplication1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            try
            {
                // IndexOutOfRangeException will be thrown
                double[] weeklyWages = { 3, 4, 5 };

                Console.WriteLine("Values being displayed from array");
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("\n\t" + weeklyWages[i]);
                }



           


               

            }


            catch (IndexOutOfRangeException e)
            {
                Console.Error.WriteLine(
                    "\n\nError in loop termination condition.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }

              //// DivideByZeroException will be thrown
            //int input;

                //Console.Write("\n\tEnter a number:\t");
            //input = int.Parse(Console.ReadLine());
            //calcResult = (input / (input - input));
            //Console.WriteLine(calcResult.ToString());


            catch (FormatException e)
            {
                Console.Error.WriteLine(
                    "\nError in parameter types.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }

                //// FormatException will be thrown
            //int calcResult;

                //for (int i = 1; i <= 4; i++)
            //{
            //    Console.Write("\nEnter a number\n" +
            //        "(or letter to throw an exception): ");
            //    calcResult = 3 * int.Parse(Console.ReadLine());
            //    Console.WriteLine(calcResult.ToString());
            //}
            
            catch (ArithmeticException e)
            {
                Console.Error.WriteLine(
                    "\nArithmeticException thrown.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }

                //// Exception will be thrown
            //short shortInput;

                //Console.Write("\n\tEnter a number greater than 32767: ");
            //shortInput = short.Parse(Console.ReadLine());
            //Console.WriteLine(shortInput.ToString());
            
            catch (Exception e)
            {
                Console.Error.WriteLine(
                    "\nValue entered exceeds the range of the\n" +
                    "data type designated to store the input.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }
            Console.ReadKey();
        }
    }
}

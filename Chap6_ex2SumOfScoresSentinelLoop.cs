using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {

        static string takeScores()
        {


            Console.Write(" To end the application enter 0. Or enter a grade between 1 and 100. ");

            string inStringValue = Console.ReadLine();


            return inStringValue;
        }

        
            /*
        static int testScore(string inStringValue)
        {
            int integerValue;
            if (int.TryParse(inStringValue, out integerValue) == false || int.Parse(inStringValue) > 100)
            {
                Console.WriteLine("Invalid input");
                Console.Write("Please re-enter an integer value between 1 and 100. ");
                inStringValue = Console.ReadLine();
            } 
            
            */

        /*else if ( int.Parse(inStringValue) > 100)
        {
            Console.WriteLine("Invalid input");
            Console.Write("Please re-enter an integer value between 1 and 100. ");
            inStringValue = Console.ReadLine();
        }
         * 

        // || int.Parse(inStringValue) > 100

      //  return integerValue;
    }
        
         * */

        static void patentIt()
        {


        }

        public static void Main(string[] args)
        {



            //write a sentinel-controlled while loop that allows any number of temperatures to be entered. the average temperature should be calculated and displayed.

            Console.Write("This is an academic score average application.");
            int theScore = 0;

            int anotherScore = 0;

            string inStringValue = System.Console.ReadLine();


            //int integerValue = testScore(inStringValue);

            int integerValue;

            do
            {
                if (int.TryParse(inStringValue, out integerValue) == false || int.Parse(inStringValue) > 100)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("Please re-enter an integer value between 1 and 100. ");
                    inStringValue = Console.ReadLine();
                } 
                else if (0<integerValue& integerValue<100)
                theScore += integerValue;
                ++anotherScore;
                Console.Write(anotherScore+" scores have been submitted successfully. To end the application enter 0. Or enter a grade between 1 and 100. ");
                inStringValue = Console.ReadLine();
            }
            while (inStringValue != "0");

            do
            {
                Console.Clear();
                string average = "Average of " + anotherScore + " scores: " + (theScore / anotherScore);

                int a = int.Parse(average);

                
                Console.Write(average);
                Console.WriteLine("Exit");

            }
            while (integerValue < 1);

            

            //patentIt();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a loop body that generates random numbers between 25 and 75. write a state-controlled loop that adds all these randomly generated numbers until a value larger than 60 is generated. When a loop stops, display the number of  acceptable generated values and the sum of those values.


            Random Rnum = new Random();

            Console.Write(" this program demonstrates a state-controlled loop that generates random numbers between 25 and 75, and adds all these randomly generated numbers until a value larger than 60 is generated. Then it will display the number of  acceptable generated values and the sum of those values. \n");
           
            int randomValue,
                sumOfRandoms = 0,
                totalOfRandoms = 0;



            randomValue = Rnum.Next(25, 59);
            while (randomValue <= 60)
            {


                sumOfRandoms += randomValue;
                ++totalOfRandoms;
                Console.Write(randomValue + "\n");
                randomValue = Rnum.Next(25, 75);
            }
            
            
            Console.Write("the number of values generated: "+totalOfRandoms+"\nthe total of these values: "+totalOfRandoms);
            Console.ReadKey();
            
        }
    }
}

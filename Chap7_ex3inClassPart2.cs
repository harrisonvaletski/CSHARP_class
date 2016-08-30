using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            //latest in class assignment part 2

            /*
            


 the first class has temperature for a week. so the class is going to have an array of size 7 as there are 7 days in a week . call it tem[]. 
           
 make a constructor that takes an array an assigns it to tem. 

 to find the highest temperature simply apply the algo find max of array and do the same to find the lowest . 

 for average, sum the array and divide it to 7 . 

 for the one that compares with a particular temperature, 
 for any given temperature x. 

 int count= 0 ; 

 for (int i = 0; i<7; ++i) 
 if (temp[i]<x) count++; 

            
 in toString() print the min value and max value 
     
 for second class , call all the method of first class in main . 
            */


            
            int[] four = new int[4];
            for(int count = 0; count < four.Length; count++){
            int gone;
            if (int.TryParse(Console.ReadLine(), out gone) == true)
            {
                four[count] = gone;
                count++;
            }
            else
            {
                Console.Write("invalid input");
            }
            }
            /*
            int count =0, gone;
            do{
                four[count] = int.Parse(Console.ReadLine());
                count++;
            } while (count<4);
            */
            Console.Write(four.Average());
            Console.ReadKey();

        }
    }
}

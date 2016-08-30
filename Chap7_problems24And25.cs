using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems_24_and25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bArray = new int[10];
         foreach (int val in bArray){
      Console.WriteLine(val);}
            for (int i=0; i < bArray.Length; i++)
            {
            bArray[i] += 5;
            }

            int c = 14; Array.IndexOf(bArray, c);
            Array.Sort(bArray);
            Array.Reverse(bArray);
            string[] font = { "Verdana", "Microsoft Sans Serif", "Arial", "Lucida Console", "Times New Roman" }; 
            string[] state = { "Oklahoma","Texas","New Mexico","Arizona","California","Nevada","Utah","Colorado","Wyoming","Idaho","Oregon","Montana"}

            char[] middleInitial = new char[10];
            bool[] examKey = new bool[15];
            int[] checkNumber = new int[100];
            string[] checkDate = new string[100];
            decimal[] checkAmount = new decimal[100];

        }
    }
}

Enter file contents hereusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write an app that reads in a five digit integer and determines whether it is a palindrome
            (a sequence of characters that reads the same backwards as forwards. For 
            instance: 12321, 45554, etc.) If the number is not 5 digits long, display 
            an error message and allow the user to enter a new value. [Hint: Use the remainder 
            and division operators to pick off the number’s digits one at a time, from right to left.]
            */
            
            string inValue;
            
            Console.Write("Your Palindrome Must be Five Numbers.");
            Console.WriteLine("\nPALINDROME GAME\n\nlets play the palindrome game!\nNow make your palindrome: ");
            inValue = Console.ReadLine();
        

          
            if (inValue.ElementAt(0) == inValue.ElementAt(4) && inValue.ElementAt(1) == inValue.ElementAt(3))
            {
                Console.Write("You made a great Palindrome. Great Job");
            }
            else
            {
                Console.Write("Thats not a great palindrome at all.");
            }

            Console.ReadLine();



        }
    }
}

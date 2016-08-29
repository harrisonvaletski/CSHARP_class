using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {

        const int zero = 0;
        const int one = 1;
        const int two = 2;
        const int three = 3;
        const int four = 4;
        const int five = 5;
        const int six = 6;
        const int seven = 7;
        const int eight = 8;
        const int nine = 9;
        const int ten = 10;
        const int eleven = 11;
        const int twelve = 12;
        const int thirteen = 13;
        const int fourteen = 14;
        public static String Classify(String inputValue){
            int Test = int.Parse(inputValue);
            String Result;
                            if (Test == zero){Result = "Tanks with a pH lower than 7 are considered acidic.";}
                else if (Test == one){Result =  "Tanks with a pH lower than 7 are considered acidic.";}
                else if (Test == two){Result=  "Tanks with a pH lower than 7 are considered acidic.";}
                else if (Test == three){Result =  "Tanks with a pH lower than 7 are considered acidic.";}
                else if (Test == four){ Result =  "Tanks with a pH lower than 7 are considered acidic.";}                   
                else if (Test == five){ Result =  "Tanks with a pH lower than 7 are considered acidic.";}                   
                else if (Test == six){ Result =  "Tanks with a pH lower than 7 are considered acidic.";}
                else if (Test == seven){ Result = "For most freshwater fish tanks, 7 is neutral.";}
                else if (Test == eight){ Result = "Tanks with a pH higher than 7 are alkaline.";}
                else if (Test == nine){ Result = "Tanks with a pH higher than 7 are alkaline.";}
                else if (Test == ten){ Result = "Tanks with a pH higher than 7 are alkaline.";}
                else if (Test == eleven){ Result = "Tanks with a pH higher than 7 are alkaline.";}
                else if (Test == twelve){ Result = "Tanks with a pH higher than 7 are alkaline.";}
                else if (Test == thirteen){ Result = "Tanks with a pH higher than 7 are alkaline.";}
                else if (Test == fourteen) { Result = "Tanks with a pH higher than 7 are alkaline."; }
                else
                {
                    Result = "Try again Please!";
                    
                }
                            if (Result == "Try again Please!") { String message = "The pH is a measure of the aquarium water’s alkalinity and is typically given on a 0-14 scale."; return message; }


                return Result;
}
        static void Main(string[] args)
        {
            /*
            Write an application that will enable you to display an aquarium’s pH level.
                The pH is a measure of the aquarium water’s alkalinity and is typically given on a 0-14 scale.
                For most freshwater fish tanks, 7 is neutral.
                Tanks with a pH lower than 7 are considered acidic.
                Tanks with a pH higher than 7 are alkaline.
            Allow the user to input the pH level number. 
                Display a message indicating the health (i.e., acidic, neutral, or alkaline) of the aquarium. 
            */


            Console.WriteLine("BE CAREFUL NOT TO ENTER TOO MANY NUMBERS. NUMBERS ONLY THANKS! \nThe pH is a measure of the aquarium water’s alkalinity and is typically given on a 0-14 scale.\nPlease Enter the Alkalinity of the Acquarium :");
            

            string inputValue = Console.ReadLine();

           string methodMan = "\n\n"+Program.Classify(inputValue);
           if (methodMan == "Start Over Fool!") { string iv = Console.ReadLine();
           methodMan = Program.Classify(iv);
           }
           else
           {
               Console.WriteLine(methodMan + "\n\n%%");
           }





           //GoodBye
            Console.Write("This simple Application brought to you by KBTC a production of Bates Technical College & veiwers like you. Thank You.");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        const int Category_1 = 74;
        const int Category_2 = 96;
        const int Category_3 = 111;
        const int Category_4 = 130;
        const int Category_5 = 157;


        /*

        public string ReturnClassificationOfHurricane() {

            String classificationName;
            switch (theWeather) {
                case '0': classificationNamee = "not classified as a hurricane."
                    break;
                case '1': classificationName = "Category 1";
                    break;
                case '2': classificationName = "Category 2";
                    break;
                case '3': classificationName = "Category 3";
                    break;
                case '4': classificationName = "Category 4";
                    break;
                case '5': classificationName = "Category 5";
            
            }
        


        
        }
         */

        static void Main(string[] args)
        {

            Console.WriteLine("\n\n\t\tWelcome to the Hurricane Emergency Console Application\n\n\tWhat is the wind speed in your area?");






            /*
            Write a program to calculate and display a person’s Body Mass Index (BMI).
BMI is an internationally used measure of obesity. Depending on where you live,
either use the Imperial BMI formula or the Metric Imperial Formula. Once the
BMI is calculated, display a message of the person’s status. Prompt the user for
both their weight and height. The BMI status categories, as recognized by the
U.S. Department of Health & Human Services, are shown in the table below:
BMI Weight Status
Below 18.5 Underweight
18.5 - 24.9 Normal
25 - 29.9 Overweight
30 & above Obese
    */


            string inputValue = Console.ReadLine();
            int theWeather = Convert.ToInt32(inputValue);

            if (theWeather <= Category_1)
            {
                Console.WriteLine("Not a hurricane");

            }
            else if (theWeather > Category_1 && theWeather <= Category_2)
            {
                Console.WriteLine("Category 1");
            }
            else if (theWeather > Category_2 && theWeather <= Category_3)
            {
                Console.WriteLine("Category 2");
            }
            else if (theWeather > Category_3 && theWeather <= Category_4)
            {
                Console.WriteLine("Category 3");
            }
            else if (theWeather > Category_4 && theWeather <= Category_5)
            {
                Console.WriteLine("Category 4");
            }
            else if (theWeather > Category_5)
            {
                Console.WriteLine("pray!");
            }




            Console.WriteLine("This simple Application brought to you by KBTC a production of Bates Technical College & veiwers like you. Thank You.");

            /*

                       */
            Console.ReadKey();




        }
    }
}

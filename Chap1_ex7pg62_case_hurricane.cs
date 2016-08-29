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

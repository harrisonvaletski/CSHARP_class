using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {


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


        static Double bMI(int weight ,int height)
        {
             Double kingPhillip=(weight*703)/(height*height);

            return kingPhillip;
        }

        static String decision(double amandaBynes)
        {
            string message = "" + amandaBynes;
            if (amandaBynes < 18.5) { message= amandaBynes +" UNDERWEIGHT"; }
            else if (amandaBynes > 18.4 && amandaBynes < 24.9){ message= amandaBynes+ " NORMAL";}
            else if ( amandaBynes >24.8 && amandaBynes < 29.9){message= amandaBynes+ " OVERWEIGHT";}
            else if (amandaBynes>30 ){message= amandaBynes+ " OBESE";}

            return "BODY MASS INDICATOR SCORE RESULTS ARE: "+message;
        }

        static void Main(string[] args)
        {

            Console.Write("BMI CALCULATOR\n\n\tThe Body Mass Index(BMI) formula was developed by Belgium statistician Adolphe Quetelet (1796-1874), and was known as the Quetelet Index. BMI is also referred to as 'body mass indicator'. BMI is an internationally used measure of obesity.");
            Console.WriteLine("The U.S. Department of Health & Human Services \n\tBMI\tWeight Status\n\tBelow 18.5\tUnderweight\n\t18.5-24.9\tNormal\n\t25-29.9\tOverweight\n\t30 & above\tObese");
            Console.WriteLine("Please input weight in pounds: ");
            int hanna = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank You. Now indicate height in inches: ");
            int montana = int.Parse(Console.ReadLine());
            double joey = bMI(hanna, montana);
            string captainsLogStarDate_9 = decision(joey);
            Console.WriteLine("The BMI Calculator uses the formula\n\t(Weight in pounds * 703) / (height in inches)^2 \n "+captainsLogStarDate_9);
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {


        double aLiterIsThisManyGallons = 0.26417205;


        public static void welcomeToBitCoinSpender()
        {
            Console.WriteLine("Bonjour!\n\n");
            Console.Write("Welcome to the BitCoin Fuel Purchaser\n\tTwo fuel stops, CanadianFuel and AmericanFuel are positioned next to the U.S. Canadian border.\tAt the canadian station, gas is sold by the liter.\tOn the american side it is sold by the gallon.\nFortunately, they both take BitCoins! ");
            Console.ReadKey();
            Console.Clear();
            
        }
        
        public static double userInput()
        {


            Console.Write("We can estimate your costs if you please indicate how many BitCoins you want to spend on fuel: ");
            double debug = double.Parse(Console.ReadLine());

            return debug;
        }


        public static string decision( double coins)
        {
         


            double canadaPrice = coins / 1.295;
            double americanPrice = coins / 4.5;
            double most = canadaPrice * .26417205;
            Console.WriteLine("So  with " + coins + " BitCoins you can buy " + Math.Ceiling(canadaPrice) + " Liters of fuel at CanadianFuel or " + Math.Ceiling(americanPrice) + " Gallons at AmericanFuel");
            string b= "an airport";

            if (most < americanPrice) {
                b = "CanadianFuel";
            }
            else
            {
                b = "AmericanFuel";
            }


            string a="\n\nSince "+Math.Ceiling(canadaPrice) + " Liters are equivalent to " + Math.Ceiling(most) + " Gallons, You should probably go to "+b;

            


            return a;
        }



        static void Main(string[] args)
        {
            //Two fuel stops canadianFuel and AmericanFuel are positioned next to the us canadian border at the canadian station, gas is sold by the liter. on the american side it is sold by the gallon. write an application that allows the user to input information from both stations and make a decision as to whhich station offers the most economical fuel price. test your application with 1.259 per liter against 4.5 per gallon. once the decision is made display the equivalent price.
            Program.welcomeToBitCoinSpender();
            
            
            double cost = Program.userInput();
            string p = Program.decision(cost);
            Console.Write(p);

            Console.ReadKey();

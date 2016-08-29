using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {



        int width;



        public static int setHeight()
        {

            string inputValue;	// local variables
            int height;

            Console.Write("\n\tWe're going to have to determine some initial Values.\n\t\tHeight:"
                            + " ");
            inputValue = Console.ReadLine();
            height = int.Parse(inputValue);
            return height;
        }

        public static int setWidth()
        {

            string inputValue;	// local variables
            int width;

            Console.Write("\n\t..and now the\n\t\t"
                            + "Width: ");
            inputValue = Console.ReadLine();
            width = int.Parse(inputValue);
            return width;
        }

        public static String getArea(int a, int b)
        {

            String Area = "\t\tArea:" + a * b;
            return Area;
        }

        public static String getPerimeter(int a, int b)
        {
            string Perimeter = "\t\tPerimeter =" + (a + b) * 2;
            return Perimeter;
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("\tLet\'s make a rectangle!\n\t\tAll you have to do is define the attributes\n\t Its properties will be displayed.");
            int a = setHeight();
            int b = setWidth();
            Console.WriteLine("");
            Console.WriteLine("\tSo our properties are:");
            Console.WriteLine(getPerimeter(a, b));
            Console.WriteLine(getArea(a, b));



            Console.ReadKey();
        }
    }
}

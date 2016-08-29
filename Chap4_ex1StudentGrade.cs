using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //i dont know what the book is saying about properties but i included two constructors, one with no params and one with all.
            Console.WriteLine("Student Grades\n\n\t");
            Student harrison = new Student("harrison","valetski","undergraduate","Computer Science",845162156,2);
            Console.WriteLine(harrison.toString());
            Console.ReadKey();
        }
    }
}

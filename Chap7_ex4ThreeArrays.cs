using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create three arrays of type double.
            double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] b = new double[] { 22, 32, 14, 54, 23, 71, 234, 63, 91, 11 };
            double[] c = new double[Math.Max(a.Length, b.Length)];

            c = Multiply(a, b);
            Everything(a, b, c);
        }



         //Do a compile time initialization and place different values in two of the arrays.
        public static double[] Multiply(double[] a, double[] b)
        {
            double[] c = new double[Math.Max(a.Length, b.Length)];  // Make array 3 the size of the largest of the two arrays.
            int y;

            for (y = 0; y < Math.Min(a.Length, b.Length); y++)
            {
                c[y] = a[y] * b[y];
            }

            if (a.Length > b.Length)
            {
                for (int i = y; i < c.Length; i++)
                {
                    c[i] = a[i] * 1;
                }
            }
            else
                if (b.Length > a.Length)
                {
                    for (int i = y; i < c.Length; i++)
                    {
                        c[i] = b[i] * 1;
                    }
                }
            return c;
        }

        public static void Everything(double[] a, double[] b, double[] c)
        {
            string display;
            int y;
            display = "Array1 *  Array2 = Array3\n\n";
            display += "Array1" + "\t" + "Array2" + "\t" + "Array3" + "\n";

            //produce a display using the messagebox class that shows the contents of all three arrays using a single line for an element from all three arrays.
            for (y = 0; y < Math.Min(a.Length, b.Length); y++)
            {  
                display += a[y] + "\t" + b[y] + "\t" +c[y] + "\n";
            }
            if (a.Length > b.Length)
            {
                for (int i = y; i < c.Length; i++)
                {
                    display += a[i] + "\t\t" + c[i] + "\n";
                }
            }
            else
            {
                if (b.Length > a.Length)
                {
                    for (int i = y; i < c.Length; i++)
                    {
                        display += "\t" + b[i] + "\t" + c[i] + "\n";
                    }
                }
            }

            MessageBox.Show(display, "ALL MY ARRAYS");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Class1
    {
        int[] tem = new int[7];
        public Class1(int[] tem)
        {
            this.tem = tem;
        }
        public double getAvg()
        {
            return this.tem.Sum() / tem.Length;
        }
        public int getMax()
        {
            return this.tem.Max();
        }
        public int getMin()
        {
            return this.tem.Min();
        }
        public String ToString()
        {
            string a = ""+getMax()+""+getMin();
            return a;

        }
    }
}

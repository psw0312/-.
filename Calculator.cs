using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Calculator
    {
        double a, b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public char c;
        public void add()
        {
            Console.WriteLine("{0}+{1}={2}", a,b,a + b);
        }
        public void less()
        {
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
        }
        public void multiply()
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        }
        public void divided()
        {
            if (b != 0)
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            else
                Console.WriteLine("除数不能为0");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            do
            {
                try
                {
                    c1.A = double.Parse(Console.ReadLine());
                    c1.B = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("请输入数字:");
                }
            }
            while (true);
                c1.c = Convert.ToChar(Console.ReadLine());
            switch (c1.c)
                {
                    case '+':
                        c1.add();
                        break;
                    case '-':
                        c1.less();
                        break;
                    case '*':
                        c1.multiply();
                        break;
                    case '/':
                        c1.divided();
                        break;
                }
            
        }
    }
}
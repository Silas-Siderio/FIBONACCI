using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int r;
            for (int i = 0; i < n; i++)
            {
                r = a;
                a = b;
                b = r + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}

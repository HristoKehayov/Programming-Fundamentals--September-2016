using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fib_Numbers
{
    class Fib_Numbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(num));
        }

        static int Fib(int n)
        {
            int fib0 = 1;
            int fib1 = 1;
            int currentFib = fib0 + fib1;
            if (n==1 || n==0)
            {
                return 1;
            }
            for (int i = 2; i < n; i++)
            {
                fib0 = fib1;
                fib1 = currentFib;
                currentFib = fib0 + fib1;
            }
            return currentFib;
        }
    }
}

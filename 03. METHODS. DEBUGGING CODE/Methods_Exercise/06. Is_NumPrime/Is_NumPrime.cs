using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Is_NumPrime
{
    class Is_NumPrime
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long n)
        {
            n = Math.Abs(n);
            double range = Math.Sqrt(n);
            if (n == 2) return true;
            if (n <= 1) return false;

            for (int devider = 2; devider <= range; devider++)
            {
                if (n % devider == 0) // it is devidable so its not prime
                {
                    return false;
                }
            }
           
            return true;
            
        }
    }
}

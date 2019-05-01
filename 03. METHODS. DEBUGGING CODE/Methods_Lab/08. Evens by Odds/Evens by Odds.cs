using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int MultiplicationFromOddAndEven = GetMultiplicationFromOddAndEven(number);
            Console.WriteLine(MultiplicationFromOddAndEven);
        }

        static int GetMultiplicationFromOddAndEven(int num)
        {
            int oddSum = GetOddSum(num);
            int evenSum = GetEvenSum(num);
            return oddSum * evenSum;
        }

        static int GetEvenSum(int n)
        {
            int EvenSum = 0;
            for (int i = n; i > 0; i/=10)
            {
                int lastDigit = i % 10;
                if (lastDigit % 2 == 0) //thats a even number
                {
                    EvenSum += lastDigit;
                }
                //i /= 10;
            }
            return EvenSum;
        }

        static int GetOddSum(int n)
        {
            int OddSum = 0;
            for (int i = n; i > 0; i/=10)
            {
                int lastDigit = i % 10;
                if (lastDigit % 2 != 0) //thats a even number
                {
                    OddSum += lastDigit;
                }
            }
            return OddSum;
        }
    }
}

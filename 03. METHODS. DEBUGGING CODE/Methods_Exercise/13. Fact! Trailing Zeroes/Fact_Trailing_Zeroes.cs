using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Fact__Trailing_Zeroes
{
    class Fact_Trailing_Zeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ReturnCountedZero(n);
        }

        static void ReturnCountedZero(int number)
        {
            int calculatedFactorial = CalulatedFactorial(number);

            int number_of_zero = 0;

            string str = calculatedFactorial.ToString();
            int stringlenght = str.Length - 1;
            for (int i = 0; i < stringlenght; i++)
            {
                if (str.EndsWith("0"))
                {
                    number_of_zero++;
                    str = str.Remove(stringlenght - i);
                }
                else
                {
                    Console.WriteLine(number_of_zero);
                    return;
                }
            }
        }

        static int CalulatedFactorial(int n)
        {
            int factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}

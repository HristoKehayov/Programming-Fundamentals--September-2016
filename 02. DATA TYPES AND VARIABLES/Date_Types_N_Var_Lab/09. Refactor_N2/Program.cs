using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int current_number_digits = i;
                int sum_of_digits = 0;
                while (i > 0)
                {
                    sum_of_digits += i % 10;
                    i = i / 10;
                }
                bool IS_Special_Number = (sum_of_digits == 5) || (sum_of_digits == 7) || (sum_of_digits == 11);
                Console.WriteLine($"{current_number_digits} -> {IS_Special_Number}");
                sum_of_digits = 0;
                i = current_number_digits;
            }

        }
    }
}

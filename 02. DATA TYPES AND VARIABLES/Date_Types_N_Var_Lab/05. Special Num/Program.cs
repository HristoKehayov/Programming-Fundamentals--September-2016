using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digits = i;
                int sum_of_current_set_of_number = 0;
                while (digits>0)
                {
                    sum_of_current_set_of_number += digits % 10;
                    digits /= 10;
                }

                if (sum_of_current_set_of_number == 5 ||
                    sum_of_current_set_of_number == 7 ||
                    sum_of_current_set_of_number == 11)
                {
                    Console.WriteLine(i + " -> {0}", true);
                }
                else
                {
                    Console.WriteLine(i + " -> {0}", false);
                }
                
            }
        }
    }
}

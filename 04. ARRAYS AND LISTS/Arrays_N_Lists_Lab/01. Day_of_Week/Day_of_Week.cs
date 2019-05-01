using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Day_of_Week
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] days_of_week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (num >=1 && num <=7)
            {
                Console.WriteLine(days_of_week[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}

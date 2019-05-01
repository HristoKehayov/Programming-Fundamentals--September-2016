using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_Digit
{
    class Last_Digit
    {
        static void Main(string[] args)
        {
            long userInput = long.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigit(userInput));
        }

        static string GetLastDigit(long number)
        {
            long last_digit = number % 10;
            string last_number_InText = "";
            switch (last_digit)
            {
                case 0: last_number_InText = "zero"; break;
                case 1: last_number_InText = "one"; break;
                case 2:last_number_InText = "two"; break;
                case 3:last_number_InText = "three"; break;
                case 4:last_number_InText = "four"; break;
                case 5:last_number_InText = "five"; break;
                case 6:last_number_InText = "six"; break;
                case 7:last_number_InText = "seven"; break;
                case 8:last_number_InText = "eight"; break;
                case 9: last_number_InText = "nine"; break;
                default: break;
            }
            return last_number_InText;
        }
    }
}

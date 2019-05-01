using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Num
{
    class Master_Num
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) == true && IsDivisibleBy7(i) == true && IsOneDigitEven(i) == true)
                {
                    Console.WriteLine(i); // current number is master number
                }
            }
        }

        static bool IsOneDigitEven(long num)
        {
            string str = num.ToString();
            int evenCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int currentDigit = int.Parse(str[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenCounter++;
                }
            }
            if (evenCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsDivisibleBy7(long num)
        {
            string str = num.ToString();
            int sumOfDigit = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sumOfDigit += int.Parse(str[i].ToString());
            }
            if (sumOfDigit % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPalindrome(long num)
        {
            string str = num.ToString();
            if (str.Length < 4 && str[0] == str[str.Length - 1])
            {
                return true;
            }
            else if (str.Length < 6 &&
                (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]))
            {
                return true;
            }
            else if (str.Length < 8 &&
               (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]
               && str[2] == str[str.Length - 3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

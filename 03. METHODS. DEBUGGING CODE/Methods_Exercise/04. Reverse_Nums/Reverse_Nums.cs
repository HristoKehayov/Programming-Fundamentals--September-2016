using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Reverse_Nums
{
    class Reverse_Nums
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(Reverse_number(number));
        }

        static double Reverse_number(double num)
        {
            string number_in_string = num.ToString();
            char[] valuechar = number_in_string.ToArray();
            string reverted_numbers = "";
            for (int i = valuechar.Length - 1; i >= 0; i--)
            {
                reverted_numbers += valuechar[i].ToString();
            }
            num = double.Parse(reverted_numbers);
            return num;
        }
    }
}

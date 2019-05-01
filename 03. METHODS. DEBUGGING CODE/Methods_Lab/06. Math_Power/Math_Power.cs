using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Math_Power
    {
        static void Main()
        {
            double user_input_num1 = double.Parse(Console.ReadLine());
            double user_input_num2 = double.Parse(Console.ReadLine());
            double result = Raise_number_calculator(user_input_num1, user_input_num2);
            Console.WriteLine(result);
        }

        static double Raise_number_calculator(double num1, double num2)
        {
            //int result = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    result *= num1;
            //}
            double result = (double)Math.Pow(num1, num2);
            return result;
        }

    }
}

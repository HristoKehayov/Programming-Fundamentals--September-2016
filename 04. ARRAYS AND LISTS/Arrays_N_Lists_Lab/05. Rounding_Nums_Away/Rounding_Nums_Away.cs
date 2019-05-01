using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Nums_Away
{
    class Rounding_Nums_Away
    {
        static void Main(string[] args)
        {
            // (input) seperate numbers and put it into arrays;
            string numbers = Console.ReadLine();
            string[] strinArr = numbers.Split(' ');

            double[] numArr = new double[strinArr.Length];

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = double.Parse(strinArr[i]);
            }
            //

            for (int i = 0; i < numArr.Length; i++)
            {
                double absolute_value_of_num = Math.Abs(numArr[i]);
                double summerizedNum = absolute_value_of_num + 0.5;
                double truncated_Num = Math.Truncate(summerizedNum);
                if (numArr[i] > 0)
                {
                    Console.WriteLine(numArr[i] + " => " + truncated_Num);

                    // the second way to solve the task
                    //Console.WriteLine(numArr[i] + " => " + Math.Round(numArr[i], MidpointRounding.AwayFromZero));
                    //
                }
                else
                {
                    Console.WriteLine(numArr[i] + " => " + truncated_Num * -1);
                }
                
            }
        }
    }
}

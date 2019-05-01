using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNumOfAll = Getmax(num1, num2, num3);

            Console.WriteLine(maxNumOfAll);
        }

        static int Getmax(int num1, int num2, int num3)
        {
            int maxNum1 = Math.Max(num1, num2);
            int maxNum2 = Math.Max(num2, num3);
            int maxNumOfAll = Math.Max(maxNum1, maxNum2);
            return maxNumOfAll;
        }
        
    }
}

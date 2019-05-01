using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_Int_Number
{
    class Sign_Int_Number
    {
        static void Main()
        {
            int userInput_number = int.Parse(Console.ReadLine());
            PrintSign(userInput_number);
        }

        static void PrintSign(int number)
        {
            //positive
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
    }

}

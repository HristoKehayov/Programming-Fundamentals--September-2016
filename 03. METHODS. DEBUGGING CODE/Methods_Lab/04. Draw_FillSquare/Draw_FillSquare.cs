using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_FillSquare
{
    class Draw_FillSquare
    {
        static void Main()
        {
            int userInput = int.Parse(Console.ReadLine());
            Print_Header_Footer(userInput);
            Print_Body(userInput);
            Print_Header_Footer(userInput);
        }

        static void Print_Header_Footer(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        static void Print_Body(int number)
        {
            for (int column = 1; column < number-1; column++)
            {
                Console.Write("-");
                for (int row = 1; row <= number-1; row++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }


    }
}

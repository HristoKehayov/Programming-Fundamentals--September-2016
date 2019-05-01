using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Print_Triangle
{
    class Print_Triangle
    {
        static void Main()
        {
            Print_Triangle();
        }

        static void Print_Triangle()
        {
            int number = int.Parse(Console.ReadLine());

            for (int column = 1; column <= number; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

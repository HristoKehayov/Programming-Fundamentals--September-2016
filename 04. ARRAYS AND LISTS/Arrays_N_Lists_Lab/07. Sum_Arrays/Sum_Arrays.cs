using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Sum_Arrays
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int array1_Length = array1.Length;
            int array2_Length = array2.Length;

            int array3_Length = Math.Max(array1_Length, array2_Length);

            int[] array3 = new int[array3_Length];

            if (array1_Length>array2_Length)
            {
                // need to equlize array 2

            }
            else if (array2_Length > array1_Length)
            {
                // need to equlize array 1

            }

        }
    }
}

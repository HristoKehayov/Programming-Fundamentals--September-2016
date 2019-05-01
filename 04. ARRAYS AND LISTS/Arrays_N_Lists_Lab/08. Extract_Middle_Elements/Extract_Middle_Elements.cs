using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_Middle_Elements
{
    class Extract_Middle_Elements
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int arrayLength = array.Length;
            if (arrayLength==1)
            {
                Console.WriteLine("{0}", array[0]);
            }
            else if (arrayLength % 2 == 0)
            {
                //lenght is even(chetno)
                int elemet_1 = array[arrayLength / 2 - 1];
                int element_2 = array[arrayLength / 2];
                Console.WriteLine("{0}, {1}", elemet_1, element_2);
            }
            else if (arrayLength % 2 != 0)
            {
                // lenght is odd(nechetno)
                int elemet_1 = array[arrayLength / 2 - 1];
                int element_2 = array[arrayLength / 2];
                int element_3 = array[arrayLength / 2 + 1];
                Console.WriteLine("{0}, {1}, {2}", elemet_1, element_2, element_3);
            }


        }
    }
}

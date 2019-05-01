using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Triple_Sum
    {
        static void Main(string[] args)
        {
            //get the input and put it into array 
            string values = Console.ReadLine();
            string[] items_from_values = values.Split(' ');
            long[] arr = new long[items_from_values.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(items_from_values[i]);
            }
            //

            long sum = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    for (int p = 0; p < arr.Length; p++)
                    {
                        if (arr[p] == sum)
                        {
                            //yes
                            Console.WriteLine(arr[i] + " + " + arr[j] + " == " + sum);
                            counter++;
                            break;
                        }
                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No");
            }

        }
    }
}

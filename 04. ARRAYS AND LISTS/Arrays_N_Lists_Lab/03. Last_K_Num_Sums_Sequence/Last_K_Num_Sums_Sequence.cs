using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Num_Sums_Sequence
{
    class Last_K_Num_Sums_Sequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] nArr = new long[n];
            int k = int.Parse(Console.ReadLine());

            nArr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i-k; j <= i-1; j++)
                {
                    if (j>=0)
                    {
                        sum += nArr[j];
                    }
                    nArr[i] = sum;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(nArr[i] + " ");
            Console.WriteLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Reverse_Array_of_Strings
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();

            // 1st way to solve the problem
            //for (int i = nums.Length-1; i >= 0; i--)
            //{
            //    Console.Write(nums[i] + " ");
            //}
            //Console.WriteLine();

            //second way to solve the problem
            for (int i = 0; i < (nums.Length)/2; i++)
            {
                var tempElement = nums[i];
                nums[i] = nums[nums.Length-1 - i]; // exchange the first string with the last one

                nums[nums.Length - 1 - i] = tempElement; // exchange the last string with the 
                                                         //first one(with temp)
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

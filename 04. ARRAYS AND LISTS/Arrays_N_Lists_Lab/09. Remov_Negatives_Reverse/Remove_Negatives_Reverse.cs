using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Remov_Negatives_Reverse
{
    class Remove_Negatives_Reverse
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<string> list = new List<string>(str.Split(' '));
            List<int> intList = new List<int>();

            foreach (var element in list)
            {
                if (int.Parse(element)>0)
                {
                    intList.Add(int.Parse(element));
                }

            }
            intList.Reverse();
            foreach (var item in intList)
            {
                if (intList.Count>0)
                {
                    Console.Write("{0} {1}", item, new string(' ', 1));
                }
            }
            if (intList.Count <= 0)
            {
                Console.Write("empty");
            }

            Console.WriteLine();

        }
    }
}

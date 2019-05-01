using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Sum_Equal_Numbers
{
    class Sum_Equal_Numbers
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<string> list = new List<string>(str.Split(' '));
            List<int> intList = new List<int>();

            foreach (var element in list)
            {
                intList.Add(int.Parse(element));
            }


            for (int i = 0; i < intList.Count-1; i++)
            {
                
                while (i < intList.Count - 1)
                {
                    int numberTorightSide = intList[i + 1];
                    if (intList[i] == numberTorightSide)
                    {
                        //sumiram
                        int summedNumber = intList[i] + numberTorightSide;
                        intList[i] = summedNumber;
                        intList.RemoveAt(i + 1);
                        if (i > 0)
                        {
                            i--;
                        }
                        
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", intList));

        }
    }
}

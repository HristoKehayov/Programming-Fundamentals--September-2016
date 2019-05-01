using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            string allNumbers = Console.ReadLine().ToLower();
            string[] string_Numbers = allNumbers.Split(' ');
            double[] myInts = Array.ConvertAll(string_Numbers, double.Parse);
            SortedDictionary<double, int> dictWords = new SortedDictionary<double, int>();
            for (int i = 0; i < myInts.Length; i++)
            {
                int number_RepetitionCunter = 0;
                double currentNumbertocheck = myInts[i];
                foreach (var item in myInts)
                {
                    if (item == currentNumbertocheck)
                    {
                        number_RepetitionCunter++;
                    }
                }

                if (!dictWords.ContainsKey(currentNumbertocheck))
                {
                    dictWords.Add(currentNumbertocheck, number_RepetitionCunter);
                }

            }
            foreach (KeyValuePair<double, int> pair in dictWords)
                Console.WriteLine($"{pair.Key} -> {pair.Value} times");

        }
    }
}

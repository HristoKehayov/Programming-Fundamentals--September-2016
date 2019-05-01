using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Occurrences
{
    class Odd_Occurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string[] TextWords = text.Split(' ');
            Dictionary<string, int> dictWords = new Dictionary<string, int>();
            
            for (int i = 0; i < TextWords.Length; i++)
            {
                int word_RepetitionCunter = 0;
                string currentWordtocheck = TextWords[i];
                foreach (var item in TextWords)
                {
                    if (item == currentWordtocheck)
                    {
                        word_RepetitionCunter++;
                    }
                }

                if (!dictWords.ContainsKey(currentWordtocheck))
                {
                    dictWords.Add(currentWordtocheck, word_RepetitionCunter);
                }

            }

            foreach (KeyValuePair<string, int> pair in dictWords)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key);
                }
            }
            
        }
    }
}

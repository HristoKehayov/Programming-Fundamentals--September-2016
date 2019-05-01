using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Split_by_Word_Casing
    {
        static void Main(string[] args)
        {
            string string_text = Console.ReadLine();
            List<string> WordList = new List<string>(string_text.Split(' '));

            List<string> Lower_case_Words = new List<string>();
            List<string> Mixed_case_Words = new List<string>();
            List<string> Upper_case_Words = new List<string>();

            foreach (var element in WordList)
            {
                if (element.ToUpper() == element)
                {
                    Upper_case_Words.Add(element);
                }
                else if (element.ToLower() == element)
                {
                    Lower_case_Words.Add(element);
                }
                else
                {
                    Mixed_case_Words.Add(element);
                }
            }


            Console.WriteLine("Lower-case: " + string.Join(" ", Lower_case_Words));
            Console.WriteLine("Mixed-case: " + string.Join(" ", Mixed_case_Words));
            Console.WriteLine("Upper-case: " + string.Join(" ", Upper_case_Words));

        }
    }
}

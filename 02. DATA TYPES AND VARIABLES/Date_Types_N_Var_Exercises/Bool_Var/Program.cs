using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(input);

            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}

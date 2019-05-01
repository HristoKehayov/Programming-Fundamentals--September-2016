using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Hello_Name
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        static void PrintName()
        {
            string userInput = Console.ReadLine();
            Console.WriteLine($"Hello, {userInput}");
        }
    }
}

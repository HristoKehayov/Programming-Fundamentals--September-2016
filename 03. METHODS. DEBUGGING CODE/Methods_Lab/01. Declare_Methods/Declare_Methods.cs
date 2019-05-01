using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Declare_Methods
{
    class Declare_Methods
    {
        static void Main()
        {
            Print_Blank_Cash_Receipt();
        }

        static void Print_Blank_Cash_Receipt()
        {
            Print_Header();
            Print_Body();
            Print_Footer();
        }
        static void Print_Header()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void Print_Body()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void Print_Footer()
        {
            Console.WriteLine("------------------------------\n \u00A9 SoftUni");
        }
    }

}

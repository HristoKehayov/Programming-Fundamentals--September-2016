using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Two_Values
{
    class Two_Values
    {
        static void Main(string[] args)
        {
            string user_input_variable = Console.ReadLine(); 
            switch (user_input_variable)
            {
                case "int":
                    int user_input_num1 = int.Parse(Console.ReadLine());
                    int user_input_num2 = int.Parse(Console.ReadLine());
                    int max_number = GetIntMax(user_input_num1, user_input_num2);
                    Console.WriteLine(max_number);
                    break;
                case "char":
                    char user_input_char1 = char.Parse(Console.ReadLine());
                    char user_input_char2 = char.Parse(Console.ReadLine());
                    char max_char = GetCharMax(user_input_char1, user_input_char2);
                    Console.WriteLine(max_char);
                    break;
                case "string":
                    string user_input_string1 = Console.ReadLine();
                    string user_input_string2 = Console.ReadLine();
                    string max_string = GetStringMax(user_input_string1, user_input_string2);
                    Console.WriteLine(max_string);
                    break;
                default:
                    break;
            }
        }

        static int GetIntMax(int num1, int num2)
        {
            int max_value = Math.Max(num1, num2);
            return max_value;
        }
        static char GetCharMax(char char1, char char2)
        {
            char max_char = (char)Math.Max(char1, char2);
            return max_char;
        }
        static string GetStringMax(string string1, string string2)
        {
            string max_string = "";
            if (string1.CompareTo(string2)>=0)
            {
                max_string = string1;
            }
            else
            {
                max_string = string2;
            }

            return max_string;
        }
    }
}

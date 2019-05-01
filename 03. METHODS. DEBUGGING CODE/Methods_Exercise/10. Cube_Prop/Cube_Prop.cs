using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Prop
{
    class Cube_Prop
    {
        static void Main(string[] args)
        {
            double side_Of_Cube = double.Parse(Console.ReadLine());
            string parameter_Of_Cube = Console.ReadLine();
            Console.WriteLine(ThrowResult(side_Of_Cube, parameter_Of_Cube));
        }

        private static double ThrowResult(double side_of_cube, string parameter_of_cube)
        {
            double result = 0;
            if (parameter_of_cube == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side_of_cube, 2));
            }
            else if (parameter_of_cube == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(side_of_cube, 2));  
            }
            else if (parameter_of_cube == "area")
            {
                result = 6 * Math.Pow(side_of_cube, 2);
            }
            else
            {
                result = Math.Pow(side_of_cube, 3);
            }
            return Math.Round(result, 2);
        }
    }
}

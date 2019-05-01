using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_Area
{
    class Triangle_Area
    {
        static void Main()
        {
            double user_inputted_height = double.Parse(Console.ReadLine());
            double user_inputted_width = double.Parse(Console.ReadLine());
            double area = Triangle_Areas(user_inputted_height, user_inputted_width);
            Console.WriteLine(area);
        }

        static double Triangle_Areas(double height, double width)
        {
            return (width * height)/2;
        }
    }
}

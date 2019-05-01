using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintClosest(x1, y1, x2, y2));
        }

        static string PrintClosest(double x1, double y1, double x2, double y2)
        {
            string point = "";
            if (Math.Abs(x1)<= Math.Abs(x2) && Math.Abs(y1) <= Math.Abs(y2))
            {
                point = $"({x1}, {y1})";
                return point;
            }
            else
            {
                point = $"({x2}, {y2})";
                return point;
            }
        }
    }
}

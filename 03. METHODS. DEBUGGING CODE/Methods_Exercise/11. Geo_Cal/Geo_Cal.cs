using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geo_Cal
{
    class Geo_Cal
    {
        static void Main(string[] args)
        {
            string figure_type = Console.ReadLine();
            switch (figure_type)
            {
                case "triangle":
                    double triangle_Side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", AriaOfTriangle(triangle_Side, height));
                    break;
                case "square":
                    double square_Side = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", AriaOfSquare(square_Side));
                    break;
                case "rectangle":
                    double rect_width = double.Parse(Console.ReadLine());
                    double rect_height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", AriaOfRectangle(rect_width, rect_height));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", AriaOfCircle(radius));
                    break;
                default:
                    break;
            }
        }

        private static double AriaOfTriangle(double triangle_Side, double height)
        {
            double area = (triangle_Side * height)/2;
            return area;
        }

        private static double AriaOfSquare(double square_Side)
        {
            double area = Math.Pow(square_Side, 2);
            return area;
        }

        private static double AriaOfRectangle(double rect_width, double rect_height)
        {
            double area = rect_height * rect_width;
            return area;
        }

        private static double AriaOfCircle(double radius)
        {
            double area = Math.Pow(radius, 2) * Math.PI;
            return area;
        }
    }
}

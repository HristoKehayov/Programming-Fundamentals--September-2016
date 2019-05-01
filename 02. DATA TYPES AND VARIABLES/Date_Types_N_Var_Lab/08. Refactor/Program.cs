using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length, Width, Heigth;

            Console.Write("Length: ");
            Length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            Heigth = double.Parse(Console.ReadLine());

            double Pyramid_Volume = 0;
            Pyramid_Volume = (Length * Width * Heigth) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", Pyramid_Volume);

        }
    }
}

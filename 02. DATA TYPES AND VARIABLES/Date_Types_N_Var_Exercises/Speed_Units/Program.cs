using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float miles = meters / 1609f;

            float time = hours * 3600 + minutes * 60 + seconds;

            float meters_per_second = meters / time;
            float kilometers_per_hour = (meters_per_second * 18) / 5;
            float miles_per_hour = miles / (float)(time / 3600f);

            Console.WriteLine(meters_per_second);
            Console.WriteLine(kilometers_per_hour);
            Console.WriteLine(miles_per_hour);
        }
    }
}

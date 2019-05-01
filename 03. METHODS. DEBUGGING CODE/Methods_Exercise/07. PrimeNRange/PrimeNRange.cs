using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimeNRange
{
    class PrimeNRange
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeInRange(startRange, endRange));
        }

        static List<int> PrimeInRange(int startNum, int endtNum)
        {
            startNum = Math.Abs(startNum);
            endtNum = Math.Abs(endtNum);
            var primeNumList = new List<int>();
            int current_num = 2;

            for (int i = startNum; i <= endtNum; i++)
            {
                current_num = i;
                if (current_num % i == 0)
                {
                    
                    primeNumList.Add(current_num);
                }

            }
            
            return primeNumList;
        }
    }
}

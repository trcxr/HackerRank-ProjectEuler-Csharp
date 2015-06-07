using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Euler1
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            HashSet<Int64> list = new HashSet<Int64>();
            Int64 mul3 = 0, mul5 = 0, mul15 = 0;
            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                N--;
                Int64 a = N / 3;
                Int64 b = N / 5;
                Int64 c = N / 15;
                mul3 = 3 * (a * (a + 1) / 2);
                mul5 = 5 * (b * (b + 1) / 2);
                mul15 = 15 * (c * (c + 1) / 2);
                list.Add(mul3);
                list.Add(mul5);
                list.Add(mul15);
                long sum = list.ElementAtOrDefault(0) + list.ElementAtOrDefault(1) - list.ElementAtOrDefault(2);
                Console.WriteLine(sum);
                list.Clear();
            }
        }
    }
}
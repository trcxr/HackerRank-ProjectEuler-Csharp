using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    class Euler3
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                long N = long.Parse(Console.ReadLine());

                long temp = N;
                for (long j = 2; j <= Math.Sqrt(N); j++)
                {
                    if (j == temp)
                    {
                        break;
                    }
                    if (temp % j == 0)
                    {
                        temp = temp / j;
                        j--;
                    }
                }
                Console.WriteLine(temp);
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    class Euler2
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<UInt64> ar = new List<UInt64>();

            for (int i = 0; i < T; i++)
            {
                UInt64 sum = 0;
                UInt64 N = UInt64.Parse(Console.ReadLine());
                ar.Add(1);
                ar.Add(2);
                int j = 2;

                while (true)
                {
                    ar.Add(ar[j - 1] + ar[j - 2]);

                    if (ar[j] >= N)
                    {
                        ar.Remove(ar[j]);
                        break;
                    }
                    j++;
                }

                foreach (UInt64 item in ar)
                {
                    if (item % 2 == 0)
                    {
                        sum += item;
                    }
                }
                Console.WriteLine(sum);
                ar.Clear();
            }
        }
    }
}

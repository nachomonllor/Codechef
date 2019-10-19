https://www.codechef.com/problems/MAXDIFF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string[] nk = Console.ReadLine().Split(' ');
                int n = int.Parse(nk[0]);
                int k = int.Parse(nk[1]);
                long[] w = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

                //int n = 5, k = 2;
                //int[] w = { 8, 4, 5, 2, 10 };

                //int n =  8, k= 3;
                //int[] w = { 1, 1, 1, 1, 1, 1, 1, 1 };

                Array.Sort(w);

                long S = w.Sum();

                long S1 = 0;
                for (int i = 0; i < k; i++)
                {
                    S1 += w[i];
                }
                Array.Reverse(w);
                long S2 = 0;
                for (int i = 0; i < k; i++)
                {
                    S2 += w[i];
                }
              
                Console.WriteLine((long)Math.Max(Math.Abs(S1 - (S - S1)), Math.Abs(S2 - (S - S2))));
            }

            Console.ReadLine();
        }
    }
}

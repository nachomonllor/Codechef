https://www.codechef.com/problems/DWNLD
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
                string[] input = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                int ans = 0;
                int sumTiempo = 0;
                bool primero = false;
                for (int i = 0; i < n; i++)
                {
                    string[] TD = Console.ReadLine().Trim().Split(' ');
                    int T = int.Parse(TD[0]);
                    int D = int.Parse(TD[1]);

                    if (!primero)
                    {
                        sumTiempo += T;

                        if (sumTiempo > k)
                        {
                            ans += (sumTiempo - k) * D;
                            primero = true;
                        }
                    }
                    else
                    {
                        ans += (T * D);
                    }
                }
                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

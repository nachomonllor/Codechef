https://www.codechef.com/problems/LEPERMUT
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
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                int inversions = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            inversions++;
                        }
                    }
                }

                int local_inversions = 0;

                for (int i = 0; i + 1 < n; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        local_inversions++;
                    }
                }

                if (inversions == local_inversions)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }

            Console.ReadLine();
        }
    }
}

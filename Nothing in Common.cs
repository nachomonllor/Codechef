https://www.codechef.com/problems/NOTINCOM
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
                int m = int.Parse(input[1]);

                int[] alice = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int[] berta = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                Array.Sort(berta);

                int ans = 0;
                for (int i = 0; i < alice.Length; i++)
                {
                    if (Array.BinarySearch(berta, alice[i])>=0)
                    {
                        ans++;
                    }

                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

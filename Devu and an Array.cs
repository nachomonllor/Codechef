https://www.codechef.com/problems/DEVARRAY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Trim(). Split(' '), e => int.Parse(e));

            int L = int.MaxValue, H = 0;
            for(int i =0; i<a.Length; i++) //while (n-- > 0)
            {
                int t = a[i];
                L = Math.Min(L, t);
                H = Math.Max(H, t);
            }
            while (q-- > 0)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp >= L && temp <= H)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }


            Console.ReadLine();
        }
    }
}


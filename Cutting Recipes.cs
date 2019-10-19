https://www.codechef.com/problems/RECIPE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                int GCD = arr[1];
                for (int i = 2; i < arr.Length; i++)
                {
                    GCD = gcd(GCD, arr[i]);
                    if (GCD == 1) break;
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    Console.Write(arr[i] / GCD + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

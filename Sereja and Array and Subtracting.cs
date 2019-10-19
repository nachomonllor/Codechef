https://www.codechef.com/problems/SEAARASU
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static long gcd(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return gcd(b, a % b);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));

                long GCD = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    GCD = gcd(GCD, arr[i]);
                }

                Console.WriteLine(GCD * n);

            }

            //Console.WriteLine(Sum2(1,4));

            Console.ReadLine();
        }
    }
}

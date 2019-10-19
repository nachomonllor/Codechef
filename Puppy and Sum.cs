https://www.codechef.com/problems/PPSUM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int Sum(int n)
        {
            return (n * (n + 1)) / 2;
        }

        static int Sum2(int d, int n)
        {
            int s = Sum(n);
            for (int i = 1; i < d; i++)
            {
                s = Sum(s);
            }
            return s;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] dn = Console.ReadLine().Split(' ');
                int d = int.Parse(dn[0]);
                int n = int.Parse(dn[1]);

                Console.WriteLine(Sum2(d, n));
            }

            //Console.WriteLine(Sum2(1,4));

            Console.ReadLine();
        }
    }
}

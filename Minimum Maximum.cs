https://www.codechef.com/problems/MNMX
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
                long n = long.Parse(Console.ReadLine());
                long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));

                //int[] arr = { 4, 2, 5 };
                //int[] arr = { 1, 4, 2, 5 };
                //int[] arr = { 1, 2, 3, 4, 5, 6 };

                Console.WriteLine((long)(arr.Min() * (n - 1)));

            }

            Console.ReadLine();

        }
    }
}

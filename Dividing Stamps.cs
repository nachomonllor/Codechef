https://www.codechef.com/problems/DIVIDING
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

            long n = long.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            //int n = 5;
            //int[] a = { 7, 4, 1, 1, 2 };
           
            //int n = 5;
            //int[] a = { 1,1,1,1,1 };

            if ((n * (n + 1)) / 2 == a.Sum())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


            Console.ReadLine();
        }
    }
}

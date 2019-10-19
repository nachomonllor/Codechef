https://www.codechef.com/problems/LECANDY
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
                string[] nc = Console.ReadLine().Split(' ');
                int n = int.Parse(nc[0]);
                int c = int.Parse(nc[1]);

                long sum = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e)).Sum();

                if (c>=sum)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

        }
    }
}

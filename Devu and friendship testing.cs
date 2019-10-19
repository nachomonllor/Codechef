https://www.codechef.com/problems/CFRTEST
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
                int[] d = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                Console.WriteLine(d.Distinct().ToArray().Length);

            }

            Console.ReadLine();
        }
    }
}

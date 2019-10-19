https://www.codechef.com/problems/REMISS
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
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                Console.WriteLine(Math.Max(a, b)+ " " + (a + b));
            }


            Console.ReadLine();
        }
    }
}

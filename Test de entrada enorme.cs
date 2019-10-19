https://www.codechef.com/problems/INTEST
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
            int n, k;
            string[] input = Console.ReadLine().Split(' ');

            n = int.Parse(input[0]);
            k = int.Parse(input[1]);

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine());

                if (t % k == 0) cont++;

            }

            Console.WriteLine(cont);

            Console.ReadLine();

        }
    }
}

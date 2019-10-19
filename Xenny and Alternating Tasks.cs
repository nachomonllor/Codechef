https://www.codechef.com/problems/XENTASK
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
                int[] X = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int[] Y = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                int a = 0, b = 0;
               
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        a += X[i];
                        b += Y[i];
                    }
                    else
                    {
                        a += Y[i];
                        b += X[i];
                    }
                }

                Console.WriteLine(Math.Min(a, b));

            }

            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/GDOG
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
                
                long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
                long n = arr[0];
                long k = arr[1];

                long max = 0;
                for(int i =1; i<=k; i++)
                {
                    max = Math.Max(max, n % i);
                }
                Console.WriteLine(max);


            }

             Console.ReadLine();

        }
    }
}

https://www.codechef.com/problems/FRUITS
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
                string[] input = Console.ReadLine().Trim().Split(' ');

                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int k = int.Parse(input[2]);

                if (m == n)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int dif = Math.Abs(n - m);
                    if (k <= dif)
                    {
                        if (n < m)
                        {
                            n += k;
                        }
                        else if (m < n)
                        {
                            m += k;
                        }
                    }
                    else if (k > dif)
                    {
                        if (n < m)
                        {
                            n += dif;
                        }
                        else if (m < n)
                        {
                            m += dif;
                        }
                    }

                    Console.WriteLine(Math.Abs(n - m));
                }
               
            }

            Console.ReadLine();

        }
    }
}

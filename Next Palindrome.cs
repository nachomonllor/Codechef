https://www.codechef.com/problems/NXTPALIN
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
                long n = int.Parse(Console.ReadLine());

                long ans = n + 1;
                for (long i = n; ; i++)
                {
                    char[] rev = i.ToString().ToCharArray();
                    Array.Reverse(rev);
                    if (new string(rev) == i.ToString())
                    {
                        ans = i;
                        break;
                    }
                }
                Console.WriteLine(ans);


            }

            Console.ReadLine();
        }
    }
}

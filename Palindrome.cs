https://www.codechef.com/problems/DPC206
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static bool esPalin(string s)
        {
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            if (new string(rev) == s)
            {
                return true;
            }
            return false;
        }

        static string rev(string s)
        {
            char[] r = s.ToCharArray();
            Array.Reverse(r);
            return new string(r);
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int p =   int.Parse(Console.ReadLine());

                int res = p;
                int adiciones = 0;
                while (!esPalin(res.ToString()))
                {
                   // Console.WriteLine(p + " " + rev(res.ToString()));
                    res = p + int.Parse(rev(p.ToString()));
                    adiciones++;
                    p = res;
                }
                Console.WriteLine(adiciones + " " + res);

            }

            Console.ReadLine();
        }
    }
}

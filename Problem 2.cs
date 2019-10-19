https://www.codechef.com/problems/CMB02
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
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            if (new string(c) == s) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int ans = 0;
            while (t-- > 0)
            {
                int K = int.Parse(Console.ReadLine());

                for (int i = K + 1; ; i++)
                {
                    if (esPalin(i.ToString()))
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

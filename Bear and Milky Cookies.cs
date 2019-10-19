https://www.codechef.com/problems/COOMILK

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

                string[] s = Console.ReadLine().Trim().Split(' ');

                string ans = "YES";

                if (s.Length == 1 && s[0] == "cookie")
                {
                    ans = "NO";
                }

                for (int i = 0; i+1 < s.Length; i++)
                {
                    if (s[i] == "cookie" && s[i + 1] == "cookie")
                    {
                        ans = "NO";
                        break;
                    }
                }

                if (s[s.Length - 1] == "cookie")
                {
                    ans = "NO";
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}


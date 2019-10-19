https://www.codechef.com/problems/MSTRINGS

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
                string s = Console.ReadLine();

                string ans = "YES";

                for (int i = 0; i < s.Length && ans=="YES"; i++)
                {
                    for (int j = i; j < s.Length &&ans =="YES"; j++)
                    {
                        string subs = s.Substring(i, j - i + 1);
                        //Console.WriteLine(subs);

                        char[] r = subs.ToCharArray();
                        Array.Reverse(r);
                        string rev = new string(r);
                        if (!s.Contains(rev))
                        {
                            ans = "NO";
                            break;
                        }
                    }
                }

                Console.WriteLine(ans);

            }
            Console.ReadLine();
        }
    }
}

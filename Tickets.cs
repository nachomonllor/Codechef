https://www.codechef.com/problems/TICKETS5
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

                //string s = "ABABABAC";
                string s = Console.ReadLine();

                string par = s.Substring(0, 2);

                if (par[0] == par[1])
                {
                    Console.WriteLine("NO");
                    continue;
                }

                string ans = "YES";
                int i;
                for (i = 2; i < s.Length - 1; i += 2)
                {
                    //Console.WriteLine(s.Substring(i, 2));
                    if (s.Substring(i, 2) != par)
                    {
                        ans = "NO";
                        break;
                    }
                }

                if (s.Length % 2 != 0)
                {
                    if (s[s.Length - 1] != s[0])
                    {
                        ans = "NO";
                    }
                }

                //Console.WriteLine(i);

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/CSTRIKE3
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

                HashSet<char> hs = new HashSet<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    hs.Add(s[i]);
                }
                if (hs.Count % 2 == 0)
                {
                    Console.WriteLine("Terrorist");
                }
                else
                {
                    Console.WriteLine("Counter Terrorist");
                }
            }

            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/EPI03
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

            string s = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());

            int ans = 0;
            foreach (char c in s)
            {
                if (ch == c)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}

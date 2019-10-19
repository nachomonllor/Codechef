https://www.codechef.com/problems/WORDCNT
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
                Console.WriteLine(s.Split(' ').Length);
            }

            Console.ReadLine();
        }
    }
}

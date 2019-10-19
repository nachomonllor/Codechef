https://www.codechef.com/problems/ERROR

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

                if (s.Contains("010") || s.Contains("101"))
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Bad");
                }
            }

            Console.ReadLine();
        }
    }
}


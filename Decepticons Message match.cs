https://www.codechef.com/problems/NOPC1
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

            string M = Console.ReadLine();
            string S = Console.ReadLine();

            if (M.Contains(S))
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }

            Console.ReadLine();
        }
    }
}


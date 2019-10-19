https://www.codechef.com/problems/FLOW008
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

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 10)
                {
                    Console.WriteLine("What an obedient servant you are!");
                }
                else
                {
                    Console.WriteLine("-1");
                }


            }


            Console.ReadLine();
        }
    }
}


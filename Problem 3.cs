https://www.codechef.com/problems/CMB03
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
                string[] input = Console.ReadLine().Split(' ');
                string a = input[0];
                string b = input[1];

                if (a.Contains(b))
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }

            }

            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/HEADBOB
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
                int N = int.Parse(Console.ReadLine());
                string gestos = Console.ReadLine();

                if (gestos.Contains("Y"))
                {
                    Console.WriteLine("NOT INDIAN");
                }
                else if (gestos.Contains("I"))
                {
                    Console.WriteLine("INDIAN");
                }
                else
                {
                    Console.WriteLine("NOT SURE");

                }
            }


            Console.ReadLine();
        }
    }
}

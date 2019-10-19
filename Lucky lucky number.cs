https://www.codechef.com/problems/CHEFLUCK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int cuatros = 0, sietes = 0;

                // Console.WriteLine(0 % 4);
                int i;
                for (i = n; i >= 0; i--)
                {
                    if (i % 7 == 0 && (n - i) % 4 == 0)
                    {
                        cuatros = i;
                        sietes = n - i;
                        break;
                    }
                }
                if (i < 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(cuatros);
                }


            }

            Console.ReadLine();
        }
    }
}

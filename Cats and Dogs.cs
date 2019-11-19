https://www.codechef.com/problems/CATSDOGS
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
                string[] input = Console.ReadLine().Trim().Split(' ');

                long C = long.Parse(input[0]);
                long D = long.Parse(input[1]);
                long L = long.Parse(input[2]);

                //if ( L % 4 == 0 &&  (4 * D   )<= L && L <= (4 * D + 4 * C) )
                //{
                //    Console.WriteLine("yes");
                //}
                //else
                //{
                //    Console.WriteLine("no");
                //}

                long min_cabezas = 0;
                if (L % 4 == 0)
                {
                    if (C > 2 * D)
                    {
                        min_cabezas = (C - 2 * D) + D;
                    }
                    else
                    {
                        min_cabezas = D;
                    }

                    if (4 * min_cabezas <= L && L <= 4 * D + 4 * C)
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
                else
                {
                    Console.WriteLine("no");
                }


            }

            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/FLOW014
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
                double dureza, carbono, traccion;
                dureza = double.Parse(input[0]);
                carbono = double.Parse(input[1]);
                traccion = double.Parse(input[2]);

                bool cond1 = dureza > 50;
                bool cond2 = carbono < 0.7F;
                bool cond3 = traccion > 5600;

                if (cond1 && cond2 && cond3)
                {
                    Console.WriteLine(10);
                }
                else if (cond1 && cond2)
                {
                    Console.WriteLine(9);
                }
                else if (cond2 && cond3)
                {
                    Console.WriteLine(8);
                }
                else if (cond1 && cond3)
                {
                    Console.WriteLine(7);
                }
                else if (cond1 || cond2 || cond3)
                {
                    Console.WriteLine(6);
                }
                else
                {
                    Console.WriteLine(5);
                }

            }


            Console.ReadLine();
        }
    }
}

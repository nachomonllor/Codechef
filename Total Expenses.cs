https://www.codechef.com/problems/FLOW009

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
                string[] input = Console.ReadLine().Split(' ');
                double cant = double.Parse(input[0]);
                double precio = double.Parse(input[1]);

                if (cant > 1000)
                {
                    double desc =  (cant * precio) * 0.10;
                    Console.WriteLine( ((cant * precio) - desc).ToString("0.000000") );
                }
                else
                {
                    Console.WriteLine(( cant * precio).ToString("0.000000") );
                }

            }


            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/BIT
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
                int n = int.Parse(Console.ReadLine());

                int unos = 0;
                for (int i = 1; i <= n; i++)
                {
                    int copia = i;
                    while (copia > 0)
                    {
                        unos += copia % 2;
                        copia /= 2;
                    }
                }
                Console.WriteLine(unos);

            }
            Console.ReadLine();
        }
    }
}


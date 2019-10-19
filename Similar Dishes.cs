https://www.codechef.com/problems/SIMDISH
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
                string[] a = Console.ReadLine().Trim().Split(' ');
                string[] b = Console.ReadLine().Trim().Split(' ');

                int cont = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            cont++;
                        }
                    }
                }

                Console.WriteLine(cont >= 2 ? "similar" : "dissimilar");

            }

            Console.ReadLine();
        }
 
    }
}

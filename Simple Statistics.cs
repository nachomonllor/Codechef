https://www.codechef.com/problems/SIMPSTAT
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

            int n, k, t;

            t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                n = int.Parse(input[0]);
                k = int.Parse(input[1]);

                string[] elems = Console.ReadLine().Split(' ');
                int[] enteros = Array.ConvertAll(elems, element => int.Parse(element));

                Array.Sort(enteros);

                int inicio = k;
                int fin = enteros.Length - k;

                double sum = 0;
                for (int i = inicio; i < fin; i++)
                {
                    sum += enteros[i];
                }

                Console.WriteLine(sum / (double)(enteros.Length - 2 * k));

            }


            Console.ReadLine();
        }
    }
}

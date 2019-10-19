https://www.codechef.com/problems/TEMPLELA

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
            int s = int.Parse(Console.ReadLine());

            while (s-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] h = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                int max = h.Max();
                int i;

                List<int> lista = new List<int>();
                for ( i = 1; i <= max; i++)
                {
                    lista.Add(i);
                }
                for (i = max - 1; i >= 1; i--)
                {
                    lista.Add(i);
                }

                if (lista.Count != h.Length)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    for ( i = 0; i < h.Length; i++)
                    {
                        if (h[i] != lista[i])
                        {
                            break;
                        }
                    }
                    if (i < h.Length)
                    {
                        Console.WriteLine("no");
                    }
                    else
                    {
                        Console.WriteLine("yes");
                    }
                }

            }

            Console.ReadLine();
        }
 
    }
}

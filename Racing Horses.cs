https://www.codechef.com/problems/HORSES
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
                string[] elems = Console.ReadLine().Split(' ');
                int[] S = Array.ConvertAll(elems, element => int.Parse(element));

                int min_dif =int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        min_dif = Math.Min(Math.Abs(S[i] - S[j]), min_dif);
                    }
                }

                Console.WriteLine(min_dif);

            }


        }
    }
}


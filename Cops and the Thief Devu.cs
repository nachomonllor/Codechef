https://www.codechef.com/problems/COPS
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
                string[] Mxy = Console.ReadLine().Split(' ');
                int M = int.Parse(Mxy[0]);
                int x = int.Parse(Mxy[1]);
                int y = int.Parse(Mxy[2]);

                string[] h = Console.ReadLine().Split(' ');
                int[] houses = Array.ConvertAll(h, element => int.Parse(element));

                bool[] marcas = new bool[101];

                int margen = x * y;

                foreach (int elem in houses)
                {
                    for (int i = elem - margen; i <= elem + margen; i++)
                    {
                        if (i >= 0 && i <= 100)
                        {
                            marcas[i] = true;
                        }
                    }

                }

                int ans = 0;
                for (int i = 1; i < marcas.Length; i++)
                {
                    if (marcas[i])
                    {
                        // Console.Write("1 ");
                    }
                    else
                    {
                        ans++;
                        //  Console.Write("0 ");
                    }
                }

                Console.WriteLine(ans);

            }


            Console.ReadLine();
        }
    }
}


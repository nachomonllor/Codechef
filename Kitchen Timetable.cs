https://www.codechef.com/problems/KTTABLE

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
                int[] tiempos = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
                int[] tiempest = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));



                //int[] tiempos = { 1, 10, 15 };
                //int[] tiempest = { 1, 10, 3 };

                List<int> intervalos = new List<int>();
                intervalos.Add(tiempos[0]);

                for (int i = 1; i < tiempos.Length; i++)
                {
                    intervalos.Add(tiempos[i] - tiempos[i - 1]);
                }

                //foreach (int elem in intervalos)
                //{
                //    Console.Write(elem + " ");
                //}

                int ans = 0;
                for (int i = 0; i < intervalos.Count; i++)
                {
                    if (tiempest[i] <= intervalos[i])
                    {
                        ans++;
                    }
                }


                Console.WriteLine(ans);

            }


            Console.ReadLine();
        }
    }
}


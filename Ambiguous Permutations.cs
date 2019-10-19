https://www.codechef.com/problems/PERMUT2

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

            while (true)
            {

                int n = int.Parse(Console.ReadLine());

                if (n == 0) break;

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                List<int> lista = new List<int>();

                string ans = "ambiguous";

                for (int i = 0; i < arr.Length; i++)
                {
                    //Console.WriteLine(arr[ arr[i]-1] ); // + " " + (i + 1));
                    lista.Add(arr[arr[i] - 1]);

                    if (lista.Count > 1)
                    {
                        if (lista[lista.Count - 2] + 1 != lista[lista.Count - 1])
                        {
                            ans = "not ambiguous";

                            break;
                        }
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }
    }
}

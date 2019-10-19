https://www.codechef.com/OCT17/problems/MEX
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
                string[] input = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                //int[] arr = { 2, 5, 4, 9 };
                //int k = 3;
                bool[] marcas = new bool[200001];


                for (int i = 0; i < arr.Length; i++)
                {
                    marcas[arr[i]] = true;
                }

                int cont = 0;
                for (int i = 0; cont < k; i++)
                {
                    if (!marcas[i])
                    {
                        marcas[i] = true;
                        cont++;
                    }
                }

                //foreach (bool elem in marcas)
                //{
                //    Console.Write(elem ? 1 : 0);
                //    Console.Write(' ');
                //}
                Console.WriteLine(Array.IndexOf(marcas, false));


            }
            Console.ReadLine();
        }
    }
}


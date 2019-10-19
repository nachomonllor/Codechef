https://www.codechef.com/problems/LCOLLIS
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
                string[] input = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                string[] matriz = new string[n];
             
                for (int i = 0; i < n; i++)
                {
                   matriz [i]  = Console.ReadLine().Trim();   
                }

                int colisiones = 0;
                for (int j = 0; j < matriz[0].Length; j++)
                {
                    int unos = 0;
                    for (int i = 0; i < matriz.Length; i++)
                    {
                        if (matriz[i][j] == '1')
                        {
                            unos++;
                        }
                    }
                    colisiones += ( (unos * (unos - 1)) / 2);
                }


                Console.WriteLine(colisiones);

            }

            Console.ReadLine();

        }
    }
}

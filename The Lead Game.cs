https://www.codechef.com/problems/TLG

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
            //int n = 5;
            //List<int[]> lista = new List<int[]>();
            //lista.Add(new int[] { 140, 82 });
            //lista.Add(new int[] { 89, 134 });
            //lista.Add(new int[] { 90, 110 });
            //lista.Add(new int[] { 112, 106 });
            //lista.Add(new int[] { 88, 90 });

            int n = int.Parse(Console.ReadLine());
            int sumPlayer1 = 0, sumPlayer2 = 0;
            int winner = 0;
            int maxdif = 0;

            while (n-- > 0)
            {

                //foreach (int[] elem in lista)
                //{
                string[] input = Console.ReadLine().Split(' ');

                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                sumPlayer1 += a;
                sumPlayer2 += b;

                if (sumPlayer1 > sumPlayer2 && sumPlayer1 - sumPlayer2 > maxdif)
                {
                    winner = 1;
                }
                else if (sumPlayer2 > sumPlayer1 && sumPlayer2 - sumPlayer1 > maxdif)
                {
                    winner = 2;
                }

                maxdif = Math.Max(maxdif, Math.Abs(sumPlayer1 - sumPlayer2));

                //}
            }

            Console.WriteLine(winner + " " + maxdif);


            Console.ReadLine();
        }


    }
}

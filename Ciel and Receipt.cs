https://www.codechef.com/problems/CIELRCPT
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

            int[] pot = { 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

               // int p = 10;
                int p = int.Parse(Console.ReadLine());
                //int p = 256;

                int i = 0, sum = 0, answer = 0;
                while (i < pot.Length)
                {
                    if (pot[i] <= p)
                    {
                        break;
                    }
                    i++;
                }

                sum = 0;

                while (i < pot.Length && sum < p)
                {
                    while (i < pot.Length && sum + pot[i] <= p)
                    {
                        sum += pot[i];
                        //Console.Write(pot[i] + " ");
                        answer++;
                    }
                    i++;
                }


                Console.WriteLine(answer);

            }

            Console.ReadLine();
        }
    }
}


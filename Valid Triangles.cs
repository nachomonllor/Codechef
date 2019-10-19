https://www.codechef.com/problems/FLOW013
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
            int T = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int A, B, C;
                A = int.Parse(input[0]);
                B = int.Parse(input[1]);
                C = int.Parse(input[2]);
                //scanf("%d %d %d", &A, &B, &C);


                if (A + B + C == 180)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                
            }


        }
    }
}

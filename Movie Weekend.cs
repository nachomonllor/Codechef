https://www.codechef.com/problems/MOVIEWKN
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
                int[] L = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
                int[] R = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));


                //int[] L = { 2, 1, 4, 1 };
                //int[] R = { 2, 4, 1, 4 };
                //int n = L.Length;

                int max_prod = 0;
                int max_R = 0;
                int ans = 0;

                for (int i = 0; i < n; i++)
                {
                    if (L[i] * R[i] > max_prod)
                    {
                        max_prod = L[i] * R[i];
                        max_R = R[i];
                        ans = i;
                    }
                    else if (L[i] * R[i] == max_prod)
                    {
                        if (R[i] > max_R)
                        {
                            ans = i;
                            max_R = R[i];
                        }
                    }
                }

                Console.WriteLine(ans + 1);


            }

            Console.ReadLine();

        }
    }
}

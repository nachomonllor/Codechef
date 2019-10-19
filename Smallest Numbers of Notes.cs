https://www.codechef.com/problems/FLOW005
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
            int[] notas = { 100, 50, 10, 5, 2, 1 };

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int cont = 0,i=0,sum=0;
                 
                while (sum < n)
                {
                    if (sum == n)
                    {
                        break;
                    }

                    if (sum + notas[i] > n)
                    {
                        i++;
                    }
                    else
                    {
                        cont++;
                        sum += notas[i];
                    }

                }
                Console.WriteLine(cont);
            }

            Console.ReadLine();
        }
    }
}

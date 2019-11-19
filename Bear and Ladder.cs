https://www.codechef.com/problems/BRLADDER
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

            int q = int.Parse(Console.ReadLine());

            while (q-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                bool entro = false;

                if (a % 2 == 0 && b % 2 == 0)//los 2 pares
                {
                    if (b == a + 2 || b == a - 2 || a == b - 2 || a == b + 2)
                    {
                        entro = true;
                        Console.WriteLine("YES");
                    }
                }
                else if (a % 2 != 0 && b % 2 != 0)//los 2 pares
                {
                    if (b == a + 2 || b == a - 2 || a == b - 2 || a == b + 2)
                    {
                        entro = true;
                        Console.WriteLine("YES");
                    }
                }
                else if (a % 2 == 0 && b % 2 != 0)
                {
                    if (b == a - 1)
                    {
                        entro = true;
                        Console.WriteLine("YES");
                    }
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    if (a == b - 1)
                    {
                        entro = true;
                        Console.WriteLine("YES");
                    }
                }
                if (!entro)
                {
                    Console.WriteLine("NO");
                }

            }

            Console.ReadLine();
        }
    }
}

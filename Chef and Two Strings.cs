https://www.codechef.com/problems/CHEFSTLT

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

                // a?c
                // ??b

                string a = Console.ReadLine().Trim();
                string b = Console.ReadLine().Trim();

                int min_distintos = 0;
                int max_distintos = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != '?' && b[i] != '?')
                    {
                        if (a[i] != b[i])
                        {
                            min_distintos++;
                            max_distintos++;
                        }
                    }
                    else if (a[i] == '?' || b[i] == '?')
                    {
                        max_distintos++;
                    }
                }

                Console.WriteLine(min_distintos + " " + max_distintos);

            }

            Console.ReadLine();

        }
    }
}

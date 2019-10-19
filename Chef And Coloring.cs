https://www.codechef.com/problems/COLOR

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
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine(); //"RGB";

                int R = 0, G = 0, B = 0;

                for (int i = 0; i < n; i++)
                {
                    if (s[i] == 'R')
                    {
                        R++;
                    }
                    else if (s[i] == 'G')
                    {
                        G++;
                    }
                    else if (s[i] == 'B')
                    {
                        B++;
                    }
                }

                Console.WriteLine(new int[] { R + B, B + G, G + R }.Min());

            }

            Console.ReadLine();
        }
    }
}


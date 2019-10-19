https://www.codechef.com/problems/TEAMFORM
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
                int m = int.Parse(input[1]);
                int[] cont = new int[n + 1];

                while (m-- > 0)
                {
                    string[] par = Console.ReadLine().Trim().Split(' ');
                    int ui = int.Parse(par[0]);
                    int vi = int.Parse(par[1]);

                    for (int i = 0; i < cont.Length; i++)
                    {
                        cont[ui]++;
                        cont[vi]++;
                    }
                }

                int libres = 0;

                for (int i = 1; i < cont.Length; i++)
                {
                    if (cont[i] == 0)
                    {
                        libres++;
                    }
                }

                Console.WriteLine(libres % 2 == 0 ? "yes" : "no");

            }

            Console.ReadLine();
        }
 
    }
}

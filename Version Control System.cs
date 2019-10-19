https://www.codechef.com/problems/VCS

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
                string[] nmk = Console.ReadLine().Split(' ');
                int n = int.Parse(nmk[0]);
                int m = int.Parse(nmk[1]);
                int k = int.Parse(nmk[2]);

                int[] ignorados = Array.ConvertAll(Console.ReadLine().Split(' '), element => int.Parse(element));
                int[] tracked = Array.ConvertAll(Console.ReadLine().Split(' '), element => int.Parse(element));

                //int max = Math.Max(ignorados[ignorados.Length - 1], tracked[tracked.Length - 1]);
                int[] cont = new int[n + 1];

                for (int i = 0; i < ignorados.Length; i++)
                {
                    cont[ignorados[i]]++;
                }
                for (int i = 0; i < tracked.Length; i++)
                {
                    cont[tracked[i]]++;
                }

                int a = 0, b = 0;
                for (int i = 1; i < cont.Length; i++)
                {
                    if (cont[i] == 0)
                    {
                        a++;
                    }
                    else if(cont [i] == 2)
                    {
                        b++;
                    }
                }

                Console.WriteLine(  b + " " + a );

            }


            Console.ReadLine();
        }
    }
}

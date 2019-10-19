https://www.codechef.com/problems/KGP14A

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

            int N = int.Parse(Console.ReadLine());
            int caso = 1;

            while (N-- > 0)
            {
                int k = int.Parse(Console.ReadLine());
                string[] elemN = Console.ReadLine().Split(' ');
                int[] ni = Array.ConvertAll(elemN, e => int.Parse(e));

                string[] elemLap = Console.ReadLine().Split(' ');
                int[] lapices = Array.ConvertAll(elemLap, e => int.Parse(e));

                Array.Sort(ni);
                Array.Sort(lapices);

                int sum = 0;
                for (int i = 0; i < k; i++)
                {
                    sum += Math.Abs(ni[i] - lapices[i]);
                }

                Console.WriteLine("Case {0}: {1}",caso++, sum);
            }

            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/AMR14D

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
                string[] elems = Console.ReadLine().Split(' ');
                int[] tams = Array.ConvertAll(elems, e => int.Parse(e));

                var diccio = new Dictionary<int, int>();

                foreach (int el in tams)
                {
                    if (diccio.ContainsKey(el))
                    {
                        diccio[el]++;
                    }
                    else
                    {
                        diccio[el] = 1;
                    }
                }

                string ans = "YES";
                foreach (KeyValuePair<int, int> kvp in diccio)
                {
//si hay mas de uno es porque hay 2 elementos iguales, por lo tanto no se pueden encastrar
                    if (kvp.Value > 1)
                    {
                        ans = "NO";
                        break;
                    }
                }
                Console.WriteLine(ans);
            }
            Console.ReadLine();

        }

    }
}

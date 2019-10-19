https://www.codechef.com/problems/MAXCOUNT
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
                int[] A = Array.ConvertAll(elems, element => int.Parse(element));

                SortedDictionary<int, int> sortedDictio = new SortedDictionary<int, int>();

                foreach (int elem in A)
                {
                    if (sortedDictio.ContainsKey(elem))
                    {
                        sortedDictio[elem]++;
                    }
                    else
                    {
                        sortedDictio[elem] = 1;
                    }
                }

                int maxValue = int.MinValue, maxKey = int.MinValue;
                foreach (KeyValuePair<int, int> kvp in sortedDictio)
                {
                    if (kvp.Value > maxValue)
                    {
                        maxValue = kvp.Value;
                        maxKey = kvp.Key;
                    }
                }

                Console.WriteLine("{0} {1}", maxKey, maxValue);
            }

            Console.ReadLine();

        }
    }
}

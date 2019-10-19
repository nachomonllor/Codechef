https://www.codechef.com/problems/STUDVOTE
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
                int k = int.Parse(input[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                   //int n = 3, k = 2;
                   //int[] a = { 2, 1, 2 };

                   //int n = 2, k = 1;
                   //int[] a = { 1, 2 };

                Dictionary<int, int> diccio = new Dictionary<int, int>();
                for (int i = 0; i < a.Length; i++)
                {
                    diccio[i + 1] = 0;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (i + 1 == a[i])
                    {
                        diccio[i + 1] = -1;
                    }
                    if (diccio[a[i]] != -1)
                    {
                        diccio[a[i]]++;
                    }
                }

                int ans = 0;
                foreach (KeyValuePair<int, int> kvp in diccio)
                {
                    if (kvp.Value >= k)
                    {
                        ans++;
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

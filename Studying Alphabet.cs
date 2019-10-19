https://www.codechef.com/problems/ALPHABET
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

            string s = Console.ReadLine().Trim();

            int n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                string w = Console.ReadLine().Trim();

                string ans = "Yes";
                for (int j = 0; j < w.Length; j++)
                {
                    if (!s.Contains(w[j]))
                    {
                        ans = "No";
                        break;
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }
    }
}

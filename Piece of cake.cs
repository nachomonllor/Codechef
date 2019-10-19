https://www.codechef.com/problems/LCH15JAB

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

                string s = Console.ReadLine().Trim();

                Dictionary<char, int> frec = s.ToCharArray() .GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());

                string ans = "NO";
                foreach (KeyValuePair<char, int> kvp in frec)
                {
                    if (s.Length - kvp.Value == kvp.Value)
                    {
                        ans = "YES";
                        break;
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }
    }
}

https://www.codechef.com/problems/STONES

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
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                //string a = "aaa";
                //string b =  "a";

                //string a = "aA";
                //string b = "abAZ";

                //string a = "abc";
                //string b = "abcdef";

                //string a = "what";
                //string b =  "none";

                //string a = "AAAAAAAAAAAAAA";
                //string b = "AAAAAAAAAAAAAA";

                Dictionary<char, int> frec_a = a.ToCharArray().GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

                Dictionary<char, int> frec_b = b.ToCharArray().GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());

                int ans = 0;
                foreach (KeyValuePair<char, int> kvp in frec_b)
                {
                    if (frec_a.ContainsKey(kvp.Key))
                    {
                        //ans += Math.Min(kvp.Value, frec_a[kvp.Key]);
                        ans += frec_b[kvp.Key];
                    }
                }

                Console.WriteLine(ans);
            }

            Console.ReadLine();
        }

    }
}

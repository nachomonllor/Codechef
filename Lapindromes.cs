https://www.codechef.com/problems/LAPIN
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
                string s = Console.ReadLine();
                string a="", b="";
                if (s.Length % 2 == 0)
                {
                    a = s.Substring(0, s.Length / 2);
                    b = s.Substring(s.Length / 2, s.Length / 2);
                }
                else
                {
                    a = s.Substring(0, s.Length / 2);
                    b = s.Substring(s.Length / 2 + 1, s.Length / 2);
                }

                //Console.WriteLine(a);
                //Console.WriteLine(b);

                var da = new SortedDictionary<char, int>();
                var db = new SortedDictionary<char, int>();

                foreach (char ch in a)
                {
                    if (da.ContainsKey(ch))
                    {
                        da[ch]++;
                    }
                    else
                    {
                        da[ch] = 1;
                    }
                }

                foreach (char ch in b)
                {
                    if (db.ContainsKey(ch))
                    {
                        db[ch]++;
                    }
                    else
                    {
                        db[ch] = 1;
                    }
                }

                string ans = "YES";

                foreach (KeyValuePair<char, int> kvp in da)
                {
                    if (!db.ContainsKey(kvp.Key) || kvp.Value != db[kvp.Key])
                    {
                        ans = "NO";
                        break;
                    }

                }

                Console.WriteLine(  ans  );

            }


            Console.ReadLine();
        }
    }
}


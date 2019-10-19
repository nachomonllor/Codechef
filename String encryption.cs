https://www.codechef.com/problems/NOPC9


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
            string s = Console.ReadLine(); // "information";

            var freq = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }

            List<char> letras = new List<char>();
            string ans = "";
            foreach (char ch in s)
            {
                if (!letras.Contains(ch))
                {
                    letras.Add(ch);
                    ans += (ch) + ""+ freq[ch];
                }
            }
            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}


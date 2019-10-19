https://www.codechef.com/problems/BUY1GET1

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
                //string s = "ssas";
                //string s = "ssss";
                string s = Console.ReadLine();

                Dictionary<char, int> frec = s.ToCharArray().GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());

                int total = 0;
                foreach (KeyValuePair<char, int> kvp in frec)
                {
                    if (kvp.Value % 2 == 0)
                    {
                        total += kvp.Value / 2;
                    }
                    else
                    {
                        total += (kvp.Value - 1) / 2 + 1;
                    }
                }

                Console.WriteLine(total);

            }

            Console.ReadLine();
        }
    }
}

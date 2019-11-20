https://www.codechef.com/problems/STRPALIN

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

                string a = Console.ReadLine(); // "abba";
                string b = Console.ReadLine(); // "baab";

                string ans = "No";
                for (int i = 0; i < a.Length && ans == "No"; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            ans = "Yes";
                            break;
                        }
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }
    }
}

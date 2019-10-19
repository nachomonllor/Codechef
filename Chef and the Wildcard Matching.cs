https://www.codechef.com/problems/TWOSTR

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

                string a = Console.ReadLine().Trim();
                string b = Console.ReadLine().Trim();

                string ans = "Yes"; 
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != '?' && b[i] != '?')
                    {
                        if (a[i] != b[i])
                        {
                            ans = "No";
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

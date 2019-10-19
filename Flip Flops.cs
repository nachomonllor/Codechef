https://www.codechef.com/problems/RIT01

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
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                //string s = "YYYYY";
                //string s = "XYXYXYXY";
                string s = Console.ReadLine();

                int i = 0, del = 0;
                while (i < s.Length)
                {
                    while (i + 1 < s.Length && s[i] == s[i + 1])
                    {
                        del++;
                        i++;
                    }
                    i++;
                }

                Console.WriteLine(del);
            }

            Console.ReadLine();
        }
    }
}

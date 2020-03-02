https://www.codechef.com/MAY17/problems/CHEFROUT

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

               // string s = "CCCCCES";
                string s = Console.ReadLine();

                // CES
                //CESCES
                //string d = new string(s.Distinct().ToArray());

                string ans = "yes";
                if (s.Contains("SE") || s.Contains("SC") || s.Contains("EC"))
                {
                    ans = "no";
                }

                Console.WriteLine(ans);
            }

            Console.ReadLine();

        }
    }
}

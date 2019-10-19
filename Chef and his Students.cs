https://www.codechef.com/problems/CHEFSTUD
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

               // string s = "*><><><*";
                string s = Console.ReadLine();

               
                int pairs = 0;
                for (int i = 0; i + 1 < s.Length; i++)
                {
                    if (s[i] == '<' && s[i + 1] == '>')
                    {
                        pairs++;
                    }
                }

                Console.WriteLine(pairs);

            }

            Console.ReadLine();
        }
    }
}

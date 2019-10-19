https://www.codechef.com/problems/IITK1P02
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
            //string s = "abbbaaabad"; // Console.ReadLine();
            string s = Console.ReadLine();
            //string s = "aabaaaaaaaaaaa";

            int max_veces = 0;
            char max_letra = s[0];
            int i = 0;

            while (i  < s.Length)
            {
                int veces = 1;
                while (i+1<s.Length && s[i] == s[i + 1])
                {
                    i++;
                    veces++;
                }
                if (veces > max_veces)
                {
                    max_veces = veces;
                    max_letra = s[i];
                }
                if (veces == max_veces)
                {
                    if (s[i] < max_letra)
                    {
                        max_letra = s[i];
                    }
                }
                i++;
            }

            Console.WriteLine(max_letra);
            Console.WriteLine(max_veces);


            Console.ReadLine();
        }
    }
}

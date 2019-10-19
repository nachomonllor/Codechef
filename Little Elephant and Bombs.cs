https://www.codechef.com/problems/LEBOMBS

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
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();

                //string s = "10001";
                bool[] explotadas = new bool[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1')
                    {
                        explotadas[i] = true;
                        if (i - 1 >= 0)
                        {
                            explotadas[i - 1] = true;
                        }
                        if (i + 1 < s.Length)
                        {
                            
                            explotadas[i + 1] = true;
                        }
                    }
                }

                Console.WriteLine(explotadas.Count(e => e == false));

            }

            Console.ReadLine();
        }
    }
}

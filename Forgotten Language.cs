https://www.codechef.com/problems/FRGTNLNG
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

                string[] nk = Console.ReadLine().Split(' ');
                int n = int.Parse(nk[0]);
                int k = int.Parse(nk[1]);
                string[] forgot = Console.ReadLine().Split(' ');

                //List<string> palabras = new List<string>();
                string p = "";

                for (int i = 0; i < k; i++)
                {

                    string[] input = Console.ReadLine().Split(' ');
                    //p += input.Substring(1, input.Length - 1).Trim();

                    for (int j = 1; j < input.Length; j++)
                    {
                        p += input[j] + " ";
                    }
                }

                //Console.WriteLine(pals);
                string[] pals = p.Trim().Split(' ');

                foreach (string s in forgot)
                {
                    if (pals.Contains(s))
                    {
                        Console.Write("YES ");
                    }
                    else
                    {
                        Console.Write("NO ");
                    }
                }
                // Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}


https://www.codechef.com/problems/LONGSEQ
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

                string s = Console.ReadLine();

                int unos = s.Count(e => e == '1');
                int ceros = s.Length - unos;

                if (unos == 1 || ceros == 1)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }

            Console.ReadLine();
        }
    }
}

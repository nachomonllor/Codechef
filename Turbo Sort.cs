https://www.codechef.com/problems/TSORT

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

            List<int> lista = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                lista.Add(n);
            }

            lista.Sort();

            foreach (int elem in lista)
            {
                Console.WriteLine(elem);
            }


            Console.ReadLine();
        }
    }
}

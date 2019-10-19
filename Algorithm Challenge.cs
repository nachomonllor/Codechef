https://www.codechef.com/problems/SALG01

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
                int L = int.Parse(Console.ReadLine());
                string[] elems = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(elems, e => int.Parse(e));

                Console.WriteLine(Array.IndexOf(arr, arr.Max()) + 1);
            }
            Console.ReadLine();
        }
    }
}

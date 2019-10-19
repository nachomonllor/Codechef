https://www.codechef.com/problems/IITK1P05
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
                string[] elems = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(elems, e => int.Parse(e));
                Console.WriteLine(arr.Max());
            }
         
 

            Console.ReadLine();
        }
    }
}

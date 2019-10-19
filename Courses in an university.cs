https://www.codechef.com/MAY17/problems/UNICOURS

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

            // int[] a = { 0, 1, 1 };
            //int[] a = { 0, 1, 2 };

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));


                Console.WriteLine(a.Length - a.Max());
            }

            Console.ReadLine();
        }




    }
}

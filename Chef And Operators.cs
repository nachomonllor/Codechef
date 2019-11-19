https://www.codechef.com/problems/CHOPRT
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
                //string[] input = Console.ReadLine().Trim() .Split(' ');
                //long a = long.Parse(input[0]);
                //long b = long.Parse(input[1]);
                long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
                long a = arr[0];
                long b = arr[1];

                if (a > b) Console.Write("\n>");
                else if (a < b) Console.Write("\n<");
                else Console.WriteLine("\n=");
            }

            // Console.ReadLine();

        }
    }
}

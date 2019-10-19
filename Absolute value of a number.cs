https://www.codechef.com/problems/ABSNUM

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
            //Console.WriteLine(lastDigit("314159"));
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Abs(n));
            }
            Console.ReadLine();
        }
    }
}

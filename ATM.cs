https://www.codechef.com/problems/HS08TEST
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
            string[] input =  Console.ReadLine().Split(' ');

            double x =  double.Parse(input[0]);
            double y = double.Parse(input[1]);

            double ans = 0;

            if (x % 5 == 0 && (y - x) - 0.5 >=0)
            {
                ans = y - (x + 0.5);
            }
            else if (x % 5 != 0)
            {
                ans = y;
            }
            else if (!((y - x) - 0.5 >= 0))
            {
                ans = y;
            }

            Console.WriteLine(ans.ToString("0.00"));

            Console.ReadLine();
        }
    }
}

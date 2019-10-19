https://www.codechef.com/problems/POTATOES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool esPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int sqr = (int)Math.Sqrt(n);

            for (int i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] xy = Console.ReadLine().Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                int sum = x + y;

                int s = sum;
                s++;

                while (!esPrimo(s))
                {
                    s++;
                }

                Console.WriteLine(s - sum);

            }


            Console.ReadLine();
        }
    }
}

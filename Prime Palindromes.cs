https://www.codechef.com/problems/PRPALIN
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
                if (n % i == 0) return false;
            }
            return true;
        }


        static void Main(string[] args)
        {

            int n =   int.Parse(Console.ReadLine());

            int ans = n;

            for (int i = n; ; i++)
            {
                char[] rev = i.ToString().ToCharArray();
                Array.Reverse(rev);
                if (esPrimo(i) && i.ToString() == 
                    new string(rev))
                {
                    ans = i;
                    break;
                }
               
            }

            Console.WriteLine(ans);
 

            Console.ReadLine();
        }
    }
}

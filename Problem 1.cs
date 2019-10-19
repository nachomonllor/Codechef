https://www.codechef.com/problems/CMB01
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
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                char[] a = input[0].ToCharArray();
                char[] b = input[1].ToCharArray();

                Array.Reverse(a);
                Array.Reverse(b);

                int res=  int.Parse(new string(a)) + int.Parse(new string(b)) ;
                char[] revRes = res.ToString().ToCharArray();
                Array.Reverse(revRes);
                Console.WriteLine(int.Parse( new string(revRes)));
            }

            Console.ReadLine();
        }
    }
}

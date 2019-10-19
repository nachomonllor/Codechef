using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static ulong gcd(ulong a, ulong b)
        {
            if (b == 0) return a;
            else return gcd(b, a % b);
        }

        // Function to return LCM of two numbers
        static ulong lcm(ulong a, ulong b)
        {
            return (a * b) / gcd(a, b);
        }


        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                ulong[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => ulong.Parse(e));

                //int[] a = { 1, 8, 7, 11 };

                //Array.Sort(a);

                ulong min_mcm = ulong.MaxValue;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        min_mcm = Math.Min(min_mcm, lcm(a[i], a[j]));
                    }
                }

                Console.WriteLine(min_mcm);

            }


            Console.ReadLine();
        }
    }
}

https://www.codechef.com/problems/CHEFSUM
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
                long[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
                //int[] a = { 1, 2, 3 };
               // int[] a = { 3, 2, 1 };

                
            
                long prefix = a[0];
                long suffix = a.Sum();

                int min_indice = 0;
                long min_sum = prefix + suffix;

                //Console.WriteLine(prefix + " " + suffix);

                for (int i = 1; i < a.Length; i++)
                {
                    //Console.WriteLine(prefix + " " + suffix);
                    prefix += a[i];
                    suffix -= a[i - 1];
                    //Console.WriteLine(prefix + " " + suffix);

                    if (prefix + suffix < min_sum)
                    {
                        min_sum = prefix + suffix;
                        min_indice = i;
                    }

                }

                Console.WriteLine(min_indice + 1);
            }

            Console.ReadLine();
        }
    }
}

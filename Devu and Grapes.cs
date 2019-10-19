https://www.codechef.com/problems/DEVUGRAP


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       


        static long DevuAndGrapes(long[] buckets, long k)
        {
            long cont = 0;
            for (int i = 0; i < buckets.Length; i++)
            {

                if (k > buckets[i])
                {
                    cont += (k - buckets[i]);
                }
                else
                {
                    if (buckets[i] % k != 0)
                    {
                        long div = buckets[i] / k;

                        long min = Math.Min(buckets[i]-(k * div), Math.Min(  buckets[i] -(k * (div - 1)) , (k * (div + 1)) - buckets[i ]));
                        cont += min;
                    }
                }

            }
            return cont;
        }



        static void Main(string[] args)
        {
            //long[] grapes = { 10, 16, 18 };//8
            //int k = 7;
            ////long[] grapes = {  7, 14, 21 };
            //Console.WriteLine(DevuAndGrapes(grapes, k));

            //long gcdgrapes = findGCD(grapes);
            //Console.WriteLine(gcdgrapes % k);
            //Console.WriteLine(18 / 7);
            //Console.WriteLine(18 % 7);

            //long[] grapes = { 3, 5 };
            //int k = 2;
            //Console.WriteLine(DevuAndGrapes(grapes, k));

            //long[] grapes = { 1, 1, 50, 1, 1, 1 };
            //int k = 49;
            //Console.WriteLine(DevuAndGrapes(grapes, k));

            //long[] grapes = { 49 };
            //int k = 49;
            //Console.WriteLine(DevuAndGrapes(grapes, k));

            //Console.WriteLine(1 % 49);

            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                long[] grapes = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
                Console.WriteLine(DevuAndGrapes(grapes, k));
            }

            Console.ReadLine();

        }
    }
}

https://www.codechef.com/OCT17/problems/PERFCONT

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
            //int n = 3, p = 100;
            //int[] part = { 11, 1, 100 };


            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string[] input = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(input[0]);
                int p = int.Parse(input[1]);

                int[] part = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                int hard = 0, cakewalk = 0;

                for (int i = 0; i < part.Length; i++)
                {
                    if (part[i] <= p / 10)
                    {
                        hard++;
                    }
                    if (part[i] >= p / 2 )
                    {
                        cakewalk++;
                    }

                }

                if (cakewalk == 1 && hard == 2)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

            }

            Console.ReadLine();
        }
    }
}


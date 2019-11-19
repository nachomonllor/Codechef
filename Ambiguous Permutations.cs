
https://www.codechef.com/problems/PERMUT2

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

            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0) break;

                int[] arr =  Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                string ans = "ambiguous";

                for (int i = 0; i +1 < arr.Length; i++)
                {
                    if (arr[arr[i] - 1] + 1 != arr[arr[i+1] - 1])
                    {
                        ans = "not ambiguous";
                        break;
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }
    }
}

https://www.codechef.com/problems/SUBINC
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
                string[] elems = Console.ReadLine().Split(' ');
                long[] nums = Array.ConvertAll(elems, element => long.Parse(element));

                int cont = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        bool increasing = true;
                        for (int k = i + 1; k <= j; k++)
                        {
                            if (nums[k - 1] > nums[k])
                            {
                                increasing = false;
                                break;
                            }
                        }
                        if (increasing)
                        {
                            cont++;
                        }
                    }
                }

                Console.WriteLine(cont);

            }

            Console.ReadLine();
        }
    }
}

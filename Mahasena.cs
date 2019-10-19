https://www.codechef.com/problems/AMR15A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] elems = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(elems, element => int.Parse(element));

            int pares = 0, impares = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            if (pares > impares)
            {
                Console.WriteLine("READY FOR BATTLE");
            }
            else
            {
                Console.WriteLine("NOT READY");
            }

            Console.ReadLine();
        }
    }
}

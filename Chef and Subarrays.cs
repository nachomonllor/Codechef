https://www.codechef.com/problems/CHEFARRP
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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] elems = Console.ReadLine().Split(' ');
                int[] nums = Array.ConvertAll(elems, element => int.Parse(element));

                int ans = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        int prod = 1, sum = 0;
                        for (int k = i; k <= j; k++)
                        {
                            prod *= nums[k];
                            sum += nums[k];
                        }
                        if (prod == sum)
                        {
                            ans++;
                        }
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

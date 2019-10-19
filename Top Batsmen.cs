https://www.codechef.com/problems/BESTBATS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static List<List<int>> Powerset(int[] nums)
        {
            List<List<int>> ps = new List<List<int>>();
            ps.Add(new List<int>());   // add the empty set

            // for every item in the original list
            foreach (int item in nums)
            {
                List<List<int>> newPs = new List<List<int>>();

                foreach (List<int> subset in ps)
                {
                    // copy all of the current powerset's subsets
                    newPs.Add(subset);

                    // plus the subsets appended with the current item
                    List<int> newSubset = new List<int>(subset);
                    newSubset.Add(item);
                    newPs.Add(newSubset);
                }

                // powerset is now powerset of list.subList(0, list.indexOf(item)+1)
                ps = newPs;
            }

            return ps;

        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                int[] puntos = Array.ConvertAll(input, e => int.Parse(e));
                int k = int.Parse(Console.ReadLine());

                List<List<int>> ps = Powerset(puntos);

                int maxSum = 0;
                int ans = 0;
                foreach (List<int> lista in ps)
                {
                    if (lista.Count == k)
                    {
                        int sum = 0;
                        foreach (int p in lista)
                        {
                            sum += p;
                        }
                        if (sum > maxSum)
                        {
                            ans = 1;
                            maxSum = sum;
                        }
                        else if (sum == maxSum)
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


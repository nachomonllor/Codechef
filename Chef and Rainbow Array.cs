https://www.codechef.com/AUG17/problems/RAINBOWA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static bool rainbow(int[] arr)
        {
            
            int indice7 = Array.IndexOf(arr,7);
            if (indice7 < 0) return false;

            Dictionary<int, int> antes = new Dictionary<int, int>();
            Dictionary<int, int> despues = new Dictionary<int, int>();
            for (int i = 1; i <= 7; i++)
            {
                antes[i] = 0;
                despues[i] = 0;
            }

           
            for (int i = 0; i < indice7; i++)
            {
                if (!antes.ContainsKey(arr[i]))
                {
                    return false;
                }
                else
                {
                    antes[arr[i]]++;
                }
            }

            int last7 = Array.LastIndexOf(arr,7);
            for (int i = last7 + 1; i < arr.Length; i++)
            {
                if (!despues.ContainsKey(arr[i]))
                {
                    return false;
                }
                else
                {
                    despues[arr[i]]++; 
                }
            }

            for (int i = 1; i <= 6; i++)
            {
                if (antes[i] == 0) return false;
                if (despues[i] == 0) return false;
                if (antes[i] != despues[i])
                {
                    return false;
                }
            }
            return true;

        }

        static void Main(string[] args)
        {

           // int[] arr = Array.ConvertAll("1 2 3 4 4 5 6 6 6 7 6 6 6 5 4 4 3 2 1".Trim().Split(' '), e => int.Parse(e));
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                Console.WriteLine(rainbow(arr) ? "yes" : "no");

            }
            

            Console.ReadLine();
        }
    }
}

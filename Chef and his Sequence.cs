https://www.codechef.com/problems/CHEFSQ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        // is the string s a subsequence of the string t?
        public static string isSubsequence(int[] s, int[] t)
        {
            int m = s.Length;
            int n = t.Length;
            if (m == 0) return "Yes";

            int i = 0;
            for (int j = 0; j < n; j++)
            {
                if (s[i] == t[j]) i++;
                if (i == m) return "Yes";
            }
            return "No";
        }

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int lenN = int.Parse(Console.ReadLine().Trim());
                //string N = "1 20 300 4000 50000 600000"; // Console.ReadLine().Trim();
                int[] N = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int lenF = int.Parse(Console.ReadLine().Trim());
                //string F = "300 4000"; // Console.ReadLine().Trim();
                int[] F = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                Console.WriteLine(isSubsequence(F, N));
                
            }


            Console.ReadLine();
        }
    }
}

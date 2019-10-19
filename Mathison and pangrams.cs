https://www.codechef.com/problems/MATPAN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                //string input = "abcdefghijklmopqrstuvwz";

                //int[] precios = Array.ConvertAll("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26".Trim().Split(' '), e => int.Parse(e));
                int[] precios = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                string input = Console.ReadLine().Trim();
                input = input.ToLower();


                int[] frec = new int[26];
                for (char ch = 'a'; ch <= 'z'; ch++)
                {
                    frec[ch - 'a'] = 0;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    frec[input[i] - 'a']++;
                }

                //for (int i = 0; i < input.Length; i++)
                //{
                //    Console.WriteLine((char)(input[i]) + " " + frec[input[i]-'a']);
                //}
                int sum = 0;
                for (int i = 0; i < frec.Length; i++)
                {
                    //Console.WriteLine((char)(i + 'a') + " " + frec[i]);
                    if (frec[i] == 0)
                    {
                        sum += precios[i];
                    }
                }

                Console.WriteLine( sum);

            }


            Console.ReadLine();
        }
    }
}


https://www.codechef.com/problems/HOTEL

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

                //int[] a = { 13, 6, 5, 8, 2, 10, 12 };
                //int[] b = { 19, 18, 6, 9, 9, 11, 15 };

                //int[] a = { 1, 2, 3};
                //int[] b = { 4, 5, 6 };

                //int[] a ={ 1, 2, 3, 4, 5};
                //int[] b = { 2, 3, 4, 5, 6 };
                int n = int.Parse(Console.ReadLine());

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
                int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                

                int[] cont = new int[1001];


                for (int i = 0; i < n; i++)
                {
                    for (int j = a[i]; j < b[i]; j++)
                    {
                        cont[j]++;
                    }
                }

                Console.WriteLine(cont.Max());

            }


            Console.ReadLine();
        }
    }
}

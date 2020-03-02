https://www.codechef.com/problems/JOHNY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static int BuscarPos(int[] A, int k)
        {
            int tj = A[k - 1];
            Array.Sort(A);
            return Array.IndexOf(A, tj) +1;
        }

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine().Trim());
                int[] A = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int k = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine(BuscarPos(A, k));

            }

            //int[] A = { 1, 3, 4, 2 };
            //int k = 2;

            //Console.WriteLine(BuscarPos(A, k));


            Console.ReadLine();
        }
    }
}


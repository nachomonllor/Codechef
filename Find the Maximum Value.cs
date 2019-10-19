https://www.codechef.com/problems/LOSTMAX
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

                // int[] arr = { 1, 5, 1, 4, 3, 2 };
                //long [] arr = { 1, 1, 4, 3, 2 };
                long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

                int tam = arr.Length;
                int ind_tam = -1;

                for(int i =0; i<arr.Length; i++)
                {
                    if(arr[i] == tam-1)
                    {
                        ind_tam = i;
                        break;
                    }
                }


                long nuevo_max = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != ind_tam)
                    {
                        if (arr[i] > nuevo_max)
                        {
                            nuevo_max = arr[i];
                        }
                    }
                }

                Console.WriteLine(nuevo_max);

            }

            Console.ReadLine();
        }
    }
}


https://www.codechef.com/problems/VOTERS

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
            
           //int n1 = 5, n2 = 6, n3 = 5;
           //int[] votos = {
           // 23,
           // 30,
           // 42,
           // 57,
           // 90,
           // 21 ,
           // 23 ,
           // 35 ,
           // 57 ,
           // 90 ,
           // 92 ,
           // 21 ,
           // 23 ,
           // 30 ,
           // 57 ,
           // 90 };

            string[]input = Console.ReadLine().Split(' ');
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);

            int[] votos = new int[n1+n2+n3];
            for (int i = 0; i < votos.Length; i++)
            {
                votos[i] = int.Parse(Console.ReadLine());
            }

            

           Dictionary<int, int> diccio = new Dictionary<int, int>();

           foreach (int elem in votos)
           {
               if (diccio.ContainsKey(elem))
               {
                   diccio[elem]++;
               }
               else
               {
                   diccio[elem] = 1;
               }
           }

           List<int> res = new List<int>();
           foreach (KeyValuePair<int, int> kvp in diccio)
           {
               if (kvp.Value > 1)
               {
                   //Console.Write(kvp.Key + " ");
                   res.Add(kvp.Key);
               }
           }

           Console.WriteLine(res.Count);
           res.Sort();
           foreach (int elem in res)
           {
               Console.WriteLine(elem);
           }


            Console.ReadLine();
        }
    }
}


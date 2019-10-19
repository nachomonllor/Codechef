https://www.codechef.com/problems/BOOKCHEF
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
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] specialFriends = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            Dictionary<int, string> diccio = new Dictionary<int, string>();
            //string[] fps = new string[m];
            Dictionary<int, string> descartados = new Dictionary<int, string>();
            for (int i = 0; i < m; i++)
            {
                //fps[i] = Console.ReadLine();
                string[] fps = Console.ReadLine() .Split(' ');
                int f = int.Parse(fps[0]);
                int p = int.Parse(fps[1]);
                string s = fps[2];

                if (specialFriends.Contains(f))
                {
                    diccio[p] = s;
                }
                else
                {
                    descartados[p] = s;
                }
            }

            foreach (KeyValuePair<int,string> item in diccio.OrderBy(i => i.Key).Reverse())
            {
                Console.WriteLine( item.Value);
            }
            foreach (KeyValuePair<int, string> item in descartados.OrderBy(i => i.Key).Reverse())
            {
                Console.WriteLine(item.Value);
            }
            


            Console.ReadLine();
        }
    }
}


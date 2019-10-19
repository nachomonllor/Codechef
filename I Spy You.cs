https://www.codechef.com/problems/CD202
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

            //string s = "razat geze hozotazamnaza ozoraza bezehizisaza";
            string s = Console.ReadLine();

            string[] sp = s.Split(' ');

            for (int i = 0; i < sp.Length; i++)
            {
                for (int j = 0;  ; j++)
                {
                    if (j < sp[i].Length && "aeiou".Contains(sp[i][j]))
                    {
                        sp[i] = sp[i].Remove(j, 2);
                    }
                    if (j >= sp[i].Length)
                    {
                        break;
                    }
                }
                Console.Write(sp[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}

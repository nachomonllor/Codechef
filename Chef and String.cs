https://www.codechef.com/problems/CHRL2
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

          //  string s = "CHEFCHEFFFF";

           // string s = "CHECFCHEFFFF";
            string s = Console.ReadLine();
            int i, c, ch, che, chef;
            c = ch = che = chef = 0;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == 'C')
                {
                    c++;
                }
                else if (s[i] == 'H')
                {
                    if (c > 0) { c--; ch++; }
                }
                else if (s[i] == 'E')
                {
                    if (ch > 0) { ch--; che++; }
                }
                else if (s[i] == 'F')
                {
                    if (che > 0) { che--; chef++; }
                }
            }

            Console.WriteLine(chef);

            Console.ReadLine();
        }
    }
}



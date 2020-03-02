https://www.codechef.com/FEB18/problems/CHEFCHR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string s = Console.ReadLine();
                //string ans = "normal";
                int cont = 0;
                for (int i =0; i<s.Length-3; i++)
                {
                    string subs = s.Substring(i, 4);

                    if(subs.Contains('c') && subs.Contains('h') && subs.Contains('e') && subs.Contains('f'))
                    {
                        //ans = "lovely";
                        cont++;
                    }
                }

                if (cont > 0)
                {
                    Console.WriteLine("lovely" + " " + cont);
                }
                else
                {
                    Console.WriteLine("normal");
                }
            }

            Console.ReadLine();

        }
    }
}


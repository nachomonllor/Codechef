
https://www.codechef.com/problems/HOWMANY

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
            int n = int.Parse(Console.ReadLine());

            int digs = n.ToString().Length;

            if (digs <= 3)
            {
                Console.WriteLine(digs.ToString());
            }
            else
            {
                Console.WriteLine("More than 3 digits");
            }


            Console.ReadLine();
        }
    }
}

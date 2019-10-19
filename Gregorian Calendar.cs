
https://www.codechef.com/problems/FLOW015
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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int year = int.Parse(Console.ReadLine());
                DateTime fecha = new DateTime(year, 1, 1);
                Console.WriteLine(fecha.DayOfWeek.ToString().ToLower());
            }

            Console.ReadLine();
        }
    }
}

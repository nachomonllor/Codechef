﻿https://www.codechef.com/problems/DS06
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
            int win = int.Parse(Console.ReadLine());
            int lost = int.Parse(Console.ReadLine());
            int tied = int.Parse(Console.ReadLine());

            Console.WriteLine(win * 3  + tied);

            Console.ReadLine();
        }
    }
}

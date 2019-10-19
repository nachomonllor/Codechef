https://www.codechef.com/problems/FLOW010

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
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'B' || ch == 'b')
                {
                    Console.WriteLine("BattleShip");
                }
                else if (ch == 'C' || ch == 'c')
                {
                    Console.WriteLine( "Cruiser" );
                }
                else if (ch == 'D' || ch == 'd')
                {
                    Console.WriteLine(  "Destroyer" );
                }
                else if (ch == 'F' || ch == 'f')
                {
                    Console.WriteLine("Frigate");
                }


            }

            Console.ReadLine();
        }
    }
}

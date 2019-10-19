https://www.codechef.com/problems/HOLES
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

            while (t-- > 0)
            {

                //string noHoles = "CEFK"; // "C", "E", "F", "K"
                string oneHole = "ADOPQR";// ""A", "D", "O", "P", "R"
                string twoHoles = "B";

                string text = Console.ReadLine();

                int holes = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (oneHole.Contains(text[i]))
                    {
                        holes += 1;
                    }
                    else if (twoHoles.Contains(text[i]))
                    {
                        holes += 2;
                    }
                }

                Console.WriteLine(holes);

            }

            Console.ReadLine();
        }
    }
}

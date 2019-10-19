https://www.codechef.com/problems/AD2
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
                int n = int.Parse(Console.ReadLine());

                //como tiene que tener los 3 lados iguales, 
                //(me pide triangulo equilatero) multiplico por 3 a i
                int ans = 0;
                for (int i = 1; i * 3 <= n; i++)
                {
                    ans++;
                }
                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

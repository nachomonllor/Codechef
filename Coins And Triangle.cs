https://www.codechef.com/problems/TRICOIN
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
                int sum = 2;
                int res = 1;
                int altura;
                for (altura = 1; ; altura++)
                {
                    //Console.WriteLine("{0} -> {1}", res, altura);

                    if (res >= n)
                    {
                        break;
                    }
                    res += sum;
                    sum++;


                }
                // Console.WriteLine(res +" "+altura);
                if (n < res)
                {
                    Console.WriteLine(altura - 1);
                }
                else
                {
                    Console.WriteLine(altura);
                }

            }
            Console.ReadLine();

        }


    }
}


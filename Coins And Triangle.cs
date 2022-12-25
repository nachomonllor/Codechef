//https://www.codechef.com/problems/TRICOIN
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

//------------------------------Con busqueda Binaria (año 2022) --------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp65
{
    class Program
    {

        static int BusquedaBinaria(List<int> pascal, int buscado)
        {
            int left = 0, rigth = pascal.Count - 1;

            while (left <= rigth)
            {
                int middle = left + (rigth - left) /2;

                if (buscado >= pascal[middle] && buscado <= pascal[middle + 1]) 
                {
                    return middle + 1;
                }
                else if (pascal[middle] < buscado)
                {
                    left = middle + 1;
                }
                else
                {
                    rigth = middle - 1;
                }
            }

            return -1;
        }


        static void Main(string[] args)
        {
            try
            {
                List<int> pascal = new List<int>();

                int s = 0;
                for (int i = 1; s< Math.Pow(10, 9); i++)
                {
                    s += i;
                    pascal.Add(s);
                }

                int T = int.Parse(Console.ReadLine().Trim());
                List<int> test = new List<int>();
                for (int i = 0; i < T; i++)
                {
                    test.Add(int.Parse(Console.ReadLine().Trim()));
                }


                StringBuilder sb = new StringBuilder();

                //test = 3 5 7
                //ans =  2 2 3

                for (int i = 0; i < test.Count; i++)
                {
                    sb.AppendLine(BusquedaBinaria(pascal, test[i]) + "");
                }

                Console.Write(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();


        }
    }
}


https://www.codechef.com/problems/COOLING
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

                string[] elemsEmp = Console.ReadLine().Split(' ');
                string[] elemsPeso = Console.ReadLine().Split(' ');

                int[] emp = Array.ConvertAll(elemsEmp, element => int.Parse(element));
                int[] limPeso = Array.ConvertAll(elemsPeso, element => int.Parse(element));

                List<int> empanadas = emp.ToList();
                List<int> limitesPeso = limPeso.ToList();

                empanadas.Sort();
                limitesPeso.Sort();

                //int[] empanadas = { 9, 7, 16, 4, 8 };
                //int[] limitesPeso = { 8, 3, 14, 10, 10 };

                //int[] empanadas= {10, 30, 20};
                //int[] limitesPeso = { 30, 10, 20 };


                bool[] marcas = new bool[limitesPeso.Count];

                for (int i = 0; i < empanadas.Count; i++)
                {
                    int minDif = int.MaxValue;
                    int indiceMenorDif = -1;

                    for (int j = 0; j < limitesPeso.Count; j++)
                    {
                        if (limitesPeso[j] >= empanadas[i] && !marcas[j])
                        {
                            if (limitesPeso[j] - empanadas[i] < minDif)
                            {
                                minDif = limitesPeso[j] - empanadas[i];
                                indiceMenorDif = j;
                            }
                        }
                    }
                    if (indiceMenorDif > -1)
                    {
                        marcas[indiceMenorDif] = true;

                    }
                }

                int ans = 0;
                foreach (bool b in marcas)
                {
                    //Console.Write(b + " ");
                    if (b)
                    {
                        ans++;
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}


https://www.codechef.com/problems/TIDRICE
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
                List<string> votos = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    votos.Add(Console.ReadLine());
                }
                var diccio = new Dictionary<string, string>();
                foreach (string elem in votos)
                {
                    diccio[elem.Split(' ')[0]] = elem.Split(' ')[1];
                }

                int answer = 0;
                foreach (KeyValuePair<string, string> kvp in diccio)
                {
                    if (kvp.Value == "+")
                    {
                        answer++;
                    }
                    else
                    {
                        answer--;
                    }
                }

                Console.WriteLine(answer);

            }

            Console.ReadLine();
        }
    }
}

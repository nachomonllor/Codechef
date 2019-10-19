https://www.codechef.com/problems/MISSP

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
                Dictionary<int, int> diccio = new Dictionary<int, int>();

                for (int i = 0; i < n; i++)
                {
                    int elem = int.Parse(Console.ReadLine());
                    if (diccio.ContainsKey(elem))
                    {
                        diccio[elem]++;
                    }
                    else
                    {
                        diccio[elem] = 1;
                    }
                }


                int ans = 0;

                foreach (KeyValuePair<int, int> kvp in diccio)
                {
                    if (kvp.Value %2 != 0)
                    {
                        ans = (kvp.Key);
                        break;
                    }
                }

                Console.WriteLine(ans);

            }


            Console.ReadLine();
        }
    }
}

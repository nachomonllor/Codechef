https://www.codechef.com/JAN18/problems/RECTANGL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine().Trim());

            while(t-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), e => int.Parse(e));

                Dictionary<int, int> diccio = new Dictionary<int, int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (diccio.ContainsKey(arr[i]))
                    {
                        diccio[arr[i]]++;
                    }
                    else
                    {
                        diccio[arr[i]] = 1;
                    }
                }

                string ans = "YES";
                foreach (KeyValuePair<int,int> kvp in diccio)
                {
                    if(kvp.Value != 2 && kvp.Value != 4)
                    {
                        ans = "NO";
                        break;
                    }
                }

                

                Console.WriteLine(ans);

            }


            Console.ReadLine();
        }
    }
}

https://www.codechef.com/MARCH18B/problems/CHEGLOVE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine(misplaced(5));

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());

                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                //int[] a = { 1, 2, 3 };
                //int[] b = { 2, 3, 4 };


                //int[] a = { 1, 2, 1 };
                //int[] b = { 1, 2, 1 };

                string ans = "";
                bool front = true;
                bool back = true;

                for (int i = 0; i < n; i++)
                {
                    if (a[i] > b[i])
                    {
                        front = false;
                    }
                    if (a[i] > b[a.Length - i - 1])
                    {
                        back = false;
                    }
                }

                if (front && !back)
                {
                    ans = "front";
                }
                else if (!front && back)
                {
                    ans = "back";
                }
                else if (front && back)
                {
                    ans = "both";
                }
                else if (!front && !back)
                {
                    ans = "none";
                }


                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}

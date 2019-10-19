https://www.codechef.com/problems/STICKS
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
                long n = long.Parse(Console.ReadLine());

                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                // int[] a = { 1, 2, 3, 1, 2 };
                //   int[] a = { 1, 2, 2, 3 };

              //int[] a = { 1000, 1000, 2000, 2000, 3000, 3000, 4000, 4000, 5000, 5000 };
                Dictionary<int, int> diccio = new Dictionary<int, int>();

                for (int i = 0; i < a.Length; i++)
                {
                    if (diccio.ContainsKey(a[i]))
                    {
                        diccio[a[i]]++;
                    }
                    else
                    {
                        diccio[a[i]] = 1;
                    }

                }

                bool par1 = false, par2 = false;
                int res = -1;
                int x = 0, y = 0;
                foreach (KeyValuePair<int, int> kvp in diccio.OrderBy(i => i.Key).Reverse())
                {
                    //Console.WriteLine(kvp.Key + " " + kvp.Value);
                    if ((!par1 && !par2) && kvp.Value >= 4)
                    {
                        res = (kvp.Key * kvp.Key);

                        if (par1 && !par2)
                        {
                            res = (Math.Max(res, x * kvp.Key));
                        }


                        break;
                    }

                    else if (kvp.Value >= 2)
                    {
                        if (!par1)
                        {
                            x = kvp.Key;
                            par1 = true;
                        }
                        else if (par1)
                        {
                            if (!par2)
                            {
                                y = kvp.Key;
                                par2 = true;
                                res = x * y;
                                break;
                            }
                        }
                    }
                }


                //Console.WriteLine(x + " " + y);
                Console.WriteLine(res);



            }

            Console.ReadLine();
        }
    }
}

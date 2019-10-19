https://www.codechef.com/problems/SEGM01

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

                // string s = "00110011";
                //string s = "000";
                //string s = "101010101";
                // string s = "101111111111";
                // string s = "1111";
                string s = Console.ReadLine();

                int firstUno = -1;
                int lastUno = -1;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1')
                    {
                        firstUno = i;
                        break;
                    }
                }

                for (int i = s.Length - 1; i > firstUno; i--)
                {
                    if (s[i] == '1')
                    {
                        lastUno = i;
                        break;
                    }
                }

                if ( firstUno + 1 == lastUno)
                {
                    if (firstUno != -1 && lastUno != -1)
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    if (firstUno != -1 && lastUno != -1)
                    {
                        int i = firstUno;
                        for ( i = firstUno; i <= lastUno; i++)
                        {
                            if (s[i] == '0')
                            {
                                Console.WriteLine("NO");
                                break;
                            }
                        }
                        if (i >= lastUno)
                        {
                            Console.WriteLine("YES");
                        }
                    }
                    else
                    {
                        if (firstUno != -1 || lastUno != -1)
                        {
                            Console.WriteLine("YES");
                        }
                        else if (firstUno == -1 && lastUno == -1)
                        {
                            Console.WriteLine("NO");
                        }

                    }

                }

            }

            Console.ReadLine();
        }



    }
}

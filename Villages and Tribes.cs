https://www.codechef.com/NOV17/problems/VILTRIBE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                //string s = Console.ReadLine();
                //string s = "A..A..B...B";
                //string s = ".B...A...B...A...";

                // string s = "....B.A.B......B";
                //string s = "..B..B..B..";


                //string s = "A..A..B...B";//4 5
                //string s = "..A..";//1 0
                //string s = "A....A";//6 0
                //string s = "..B..B..B..";//0 7
                //string s = "B.A";
                //string s = "A...A.....B......B";
                //string s = "B.BBBBBBBBAAAAA....BB";
                // string s = "B...B...A..A..B..B"; //4 9
                //string s = "BA...BAB...B";
                //string s = "ABABABABABABABABABABABA";
                string s = Console.ReadLine();

                //int max_a = 0, max_b = 0;
                //Console.WriteLine(s.Length);

                int total_a = 0, total_b = 0;
                int a = 0, b = 0;

                char ultimo = '.';

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'A')
                    {
                        a++;
                        //if(ultimo =='A')
                        total_a += a;
                        a = 0;
                        b = 0;
                        ultimo = 'A';
                    }
                    else if (s[i] == 'B')
                    {
                        b++;
                        //if(ultimo == 'B')
                        total_b += b;
                        b = 0;
                        a = 0;
                        ultimo = 'B';
                    }

                    else if (s[i] == '.')
                    {
                        if (ultimo == 'A')
                        {
                            a++;
                            b = 0;
                        }
                        else if (ultimo == 'B')
                        {
                            b++;
                            a = 0;
                        }
                    }

                }

                Console.WriteLine(total_a + " " + total_b);

            }


            // Console.ReadLine();
        }
    }
}

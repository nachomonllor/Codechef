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

            string s = "<=<";
            //string s = "<<<";
            int p = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '<')
                {
                    p++;
                }
                else if (s[i] == '>')
                {
                    p--;
                }
                //else if (s[i] == '=')
                //{

                //}
                max = Math.Max(max, p);
            }

            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}

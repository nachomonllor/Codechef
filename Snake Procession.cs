https://www.codechef.com/problems/SNAKPROC
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static string isValid(string s)
        {
            //if (!s.Contains('H') || !s.Contains('T'))
            //{
            //    return "Invalid";
            //}

            s = s.Replace(".", "");




            if (s.IndexOf('T') < s.IndexOf('H'))
            {
                return "Invalid";
            }

            if ((s.Contains('T') && !s.Contains('H')) ||
                (s.Contains('H') && !s.Contains('T')))
            {
                return "Invalid";
            }
           

           // Console.WriteLine(s);

            if (s.Contains("HH") || s.Contains("TT"))
            {
                return "Invalid";
            }

            if (s.LastIndexOf('T') < s.LastIndexOf('H'))
            {
                return "Invalid";
            }

            return "Valid";
        }





        static void Main(string[] args)
        {
            // string s = "..H..T...HTH....T.";
            int r = int.Parse(Console.ReadLine());

            while (r-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();

                Console.WriteLine(isValid(s));

            }

            Console.ReadLine();
        }
    }
}

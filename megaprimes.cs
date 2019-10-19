https://www.codechef.com/problems/CYPRM/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {

        static bool isMegaPrime(long n)
        {
            if (n == 2) return true;

            string ns = n.ToString();
            string noPrimos = "146890";//2357

            foreach (char ch in ns)
            {
                if (noPrimos.Contains(ch))
                {
                    return false;
                }
            }

            if (n < 2) return false;
            
            if (n % 2 == 0) return false;

            long sqr = (long)Math.Sqrt(n);
            for (int i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

            Dictionary<int, int> frec = new Dictionary<int, int>();

            int cant_megap = 0;
            for (long i = 1; i <= 1000; i++)
            {
                if (isMegaPrime(i))
                {
                    cant_megap++;
                }
                if (frec.ContainsKey(cant_megap))
                {
                    frec[cant_megap]++;
                }
                else
                {
                    frec[cant_megap] = 1;
                }

                // esc.Write(cant_megap + ", ");
            }

            int l = 1;
            int r = 100;

            //int left = 0;
            //int rigth = 0;

            //bool entro = false;

            //int sum = 0;
            //foreach (KeyValuePair<int, int> kvp in frec)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}

            int sum_r = 0;
            int sum_l = 0;

            int hasta_izq = 0;
            int hasta_der = 0;

            bool entro = false;

            foreach (KeyValuePair<int, int> kvp in frec)
            {
                if (sum_l >= l && !entro)
                {
                    hasta_izq = kvp.Key;
                    entro = true;
                }
                if (sum_r >= r && hasta_izq > 0)
                {
                    //Console.WriteLine(kvp.Key);
                    hasta_der = kvp.Key;
                    break;
                }
                sum_r += kvp.Value;
                sum_l += kvp.Value;
            }

            Console.WriteLine(hasta_der - hasta_izq);

            Console.ReadLine();
        }


    }
}









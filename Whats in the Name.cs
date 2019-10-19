https://www.codechef.com/JULY17/problems/NITIKA
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
                //string s = "ganDhi";
                string s = Console.ReadLine();

                string[] sp = s.Split(' ');

                if (sp.Length == 1)
                {
                    string nombre = sp[0];
                    nombre = char.ToUpper(nombre[0]) + nombre.Substring(1).ToLower();
                    Console.WriteLine(nombre);
                }
                else if (sp.Length == 2)
                {
                    string pnombre = sp[0];
                    string apell = sp[1];

                    string inicialPNombre = char.ToUpper(pnombre[0]) + ".";
                    apell = char.ToUpper(apell[0]) + apell.Substring(1).ToLower();

                    Console.WriteLine(inicialPNombre + " " + apell);
                }
                else if (sp.Length == 3)
                {
                    string pnombre = sp[0];
                    string psegNombre = sp[1];
                    string apell = sp[2];

                    string inicialPNombre = char.ToUpper(pnombre[0]) + ".";
                    string inicialSNombre = char.ToUpper(psegNombre[0]) + ".";

                    apell = char.ToUpper(apell[0]) + apell.Substring(1).ToLower();

                    Console.WriteLine(inicialPNombre + " " + inicialSNombre + " " + apell);

                }

            }

            Console.ReadLine();
        }
    }
}

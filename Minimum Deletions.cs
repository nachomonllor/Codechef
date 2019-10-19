https://www.codechef.com/MAY18B/problems/RD19



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        static bool esPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for(int i =3; i*i <=n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
             


        static void Main(string[] args)
        {
            int[] arr = { 2, 4 };

            int g = arr[0];
            for(int i =1; i<arr.Length; i++)
            {
                g = GCD(g, arr[i]);
            }


            List<int> primos = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();


            foreach (int elem in arr)
            {
                if (esPrimo(elem))
                {
                    primos.Add(elem);
                }
                else if (elem % 2 == 0)
                {
                    pares.Add(elem);
                }
                else
                {
                    impares.Add(elem);
                }
            }

            int borrar = 0;
            if (impares.Count > 0)
            {
                bool[] borrados = new bool[impares.Max() + 1];
                
                for (int i = 0; i < impares.Count - 1; i++)
                {
                    for (int j = i + 1; j < impares.Count; j++)
                    {
                        if (impares[i] > 1 && impares[j] > 1)
                        {
                            int max = Math.Max(impares[i], impares[j]);
                            int min = Math.Min(impares[i], impares[j]);
                            if (borrados[max] == false && max % min == 0)
                            {
                                borrados[max] = true;
                                borrar++;
                            }
                        }
                    }
                }
            }

            
                int borrar_pares = 0;
                int total_pares = pares.Count;
                if (total_pares >= 1)
                {
                    borrar_pares = 1;
                }

                Console.WriteLine(borrar + borrar_pares);

            
            //int t = int.Parse(Console.ReadLine());

            //while (t-- > 0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));




            //    if(gcd == 1)
            //    {
            //        Console.WriteLine(0);
            //    }
            //    if (gcd > 1)
            //    {
            //        Console.WriteLine(-1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(borrar);
            //    }

            //}


            //Console.WriteLine(GCD(3, 55));


            Console.ReadLine();
        }
    }
}




----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        static bool esPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for(int i =3; i*i <=n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
             


        static void Main(string[] args)
        {
            int[] arr = { 2, 4 };

            int g = arr[0];
            for(int i =0; i<arr.Length; i++)
            {
                g = GCD(g, arr[i]);
            }


            List<int> primos = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();


            foreach (int elem in arr)
            {
                if (esPrimo(elem))
                {
                    primos.Add(elem);
                }
                else if (elem % 2 == 0)
                {
                    pares.Add(elem);
                }
                else
                {
                    impares.Add(elem);
                }
            }

            bool[] borrados = new bool[impares.Max()+1];
            int borrar = 0;
            for(int i =0; i<impares.Count; i++)
            {
                for(int j=i+1; j<impares.Count; j++)
                {
                    if(impares[i] > 1 && impares[j] > 1)
                    {
                        int max = Math.Max(impares[i], impares[j]);
                        int min = Math.Min(impares[i], impares[j]);
                        if (borrados[max] == false &&  max % min ==0) {
                            borrados[max] = true;
                            borrar++;
                        }
                    }
                }
            }

            int borrar_pares = 0;
            int total_pares = pares.Count;
            if(total_pares >= 1)
            {
                borrar_pares = 1;
            }

            Console.WriteLine(borrar + borrar_pares);

            //int t = int.Parse(Console.ReadLine());

            //while (t-- > 0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));




            //    if(gcd == 1)
            //    {
            //        Console.WriteLine(0);
            //    }
            //    if (gcd > 1)
            //    {
            //        Console.WriteLine(-1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(borrar);
            //    }

            //}


            //Console.WriteLine(GCD(3, 55));


            Console.ReadLine();
        }
    }
}






------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        static bool esPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for(int i =3; i*i <=n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
             


        static void Main(string[] args)
        {
            int[] arr = { 2, 4 };

            int g = arr[0];
            for(int i =0; i<arr.Length; i++)
            {
                g = GCD(g, arr[i]);
            }


            List<int> primos = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();


            foreach (int elem in arr)
            {
                if (esPrimo(elem))
                {
                    primos.Add(elem);
                }
                else if (elem % 2 == 0)
                {
                    pares.Add(elem);
                }
                else
                {
                    impares.Add(elem);
                }
            }

            bool[] borrados = new bool[impares.Count];
            int borrar = 0;
            for(int i =0; i<impares.Count; i++)
            {
                for(int j=i+1; j<impares.Count; j++)
                {
                    if(impares[i] > 1 && impares[j] > 1)
                    {
                        int max = Math.Max(impares[i], impares[j]);
                        int min = Math.Min(impares[i], impares[j]);
                        if ( max % min ==0) {
                            borrar++;
                        }
                    }
                }
            }



            //int t = int.Parse(Console.ReadLine());

            //while (t-- > 0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));




            //    if(gcd == 1)
            //    {
            //        Console.WriteLine(0);
            //    }
            //    if (gcd > 1)
            //    {
            //        Console.WriteLine(-1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(borrar);
            //    }

            //}


            //Console.WriteLine(GCD(3, 55));


            Console.ReadLine();
        }
    }
}



----------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {





        static void Main(string[] args)
        {
            int[] arr = { 2, 4 };

            //int t = int.Parse(Console.ReadLine());

            //while (t-- > 0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            int max = arr.Max();
            int[] cont = new int[max+ 1];
            for(int i =0; i<arr.Length; i++)
            {
                cont[arr[i]]++;
            }

            List<int> llenos = new List<int>();

            for(int i =0; i<cont.Length; i++)
            {
                if(cont[i] > 0)
                {
                    llenos.Add(i);
                }
            }

            int consecutivos = 0;
            for(int i =1; i<llenos.Count; i++)
            {
                consecutivos = 1;
                while(i < llenos.Count && llenos[i-1] +1 == llenos[i])
                {
                    consecutivos++;
                    i++;
                }
            }

            int res = arr.Length - consecutivos;

            Console.WriteLine(res);

           // }

                



            
            Console.ReadLine();
        }
    }
}

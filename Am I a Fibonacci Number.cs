using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        //#include <stdio.h>

        //int main()
        //{
        //    int t, i, flag;
        //    unsigned long long int n, f[6000];
        //    char s[1001];
        //    f[0] = 0;
        //    f[1] = 1;
        //    for(i=1;i<3000;i++){
        //        f[2*i-1] = f[i-1]*f[i-1] + f[i]*f[i];
        //        f[2*i]   = (2*f[i-1] + f[i])*f[i];
        //    }
        //    //for(i=0;i<50;i++) printf("%d ",f[i]);
        //    scanf("%d",&t);
        //    while(t--){
        //        scanf("%s",s);
        //        // hash
        //        n = 0;
        //        // printf("%s\n",s);
        //        for(i=0;s[i]!='\0';i++)
        //        {
        //           // printf("%d %d %d",n,s[i],i);
        //            n*=10;
        //            n+=(s[i]-'0');
        //        }
        //        // printf("\n%d ",n);
        //        flag = 0;
        //        i=0;
        //        while(i<6000){
        //            if(f[i++]==n){
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if(flag)
        //            printf("YES\n");
        //        else
        //            printf("NO\n");
        //    }
        //    return 0;
        //}

        //http://www.codechef.com/viewsolution/5247081
        static void Main(string[] args)
        {

            int[] f = new int[50];
            //char[] s  [1001];
            f[0] = 0;
            f[1] = 1;
            for (int i = 1; i < 20; i++)
            {
                f[2 * i - 1] = f[i - 1] * f[i - 1] + f[i] * f[i];
                f[2 * i] = (2 * f[i - 1] + f[i]) * f[i];
            }

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write(f[i] + " ");
            }

            Console.ReadLine();

        }



    }
}

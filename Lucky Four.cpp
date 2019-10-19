https://www.codechef.com/problems/LUCKFOUR

#include <iostream>
#include <stdio.h>
 
using namespace std;
 
int main(){
   
    int T;
    scanf("%d", &T);
   
    for(int i = 0; i < T; i++)
    {
        int N;
        scanf("%d", &N);
       
        int cont = 0;
        while(N > 0){
         
          if(N % 10==4) cont++;
           
          N/=10;  
        }
        printf("%d\n", cont);
    }
   
   
    return 0;  
}

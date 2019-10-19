https://www.codechef.com/problems/PALL01

#include <stdio.h>
#include <iostream>

using namespace std;

int main(){
    
    int T;
    scanf("%d", &T);
    
    for(int i = 0; i < T; i++)
    {
        int n;
        scanf("%d", &n);
        int copia = n;
        int rev = 0;
        while(copia > 0)
        {
            rev = rev * 10 + (copia % 10);
            copia/=10;
        }
        
        if(rev == n){
            printf("wins\n");   
        } else {
            printf("losses\n");
        }
          
    }   
    
    
    return 0;   
}

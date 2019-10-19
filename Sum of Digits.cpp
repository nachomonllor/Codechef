https://www.codechef.com/problems/FLOW006
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
       
        int sum = 0;
        while(N > 0){
            sum += N % 10;
            N /=10;
        }    
       
        printf("%d\n", sum);
       
    }
   
   
    return 0;  
}

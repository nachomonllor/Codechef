https://www.codechef.com/problems/FLOW002

#include <iostream>
#include <stdio.h>
#include <vector>


int main(){
    
    int T;
    scanf("%d", &T);
    
    for(int i  = 0; i < T; i++){
      
        int A,B;
        scanf("%d %d", &A, &B);
          
        printf("%d\n", A % B);
     
    }
    
    return 0;   
}

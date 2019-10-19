https://www.codechef.com/problems/FLOW004

#include <iostream>
#include <stdio.h>
#include <vector>
 
int main(){
   
    int T;
    scanf("%d", &T);
   
    for(int i  = 0; i < T; i++){
       
        int n;
        scanf("%d",&n);
       
        int last = n %10;
        int first = 0;
       
        while(n > 0){
          first = n % 10;  
          n/=10;  
        }  
       
        printf("%d\n", first + last);
       
    }
   
    
    return 0;  
}

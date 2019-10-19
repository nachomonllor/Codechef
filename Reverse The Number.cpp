https://www.codechef.com/problems/FLOW007

#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <vector>
 
int main(){
   
    int T;
    scanf("%d", &T);
   
    for(int i  = 0; i < T; i++){
       
        int n;
        scanf("%d",&n);
       
        int rev = 0;
        while(n > 0) {
            rev = rev * 10 + (n%10);
               
            n /=10;
        }
       
        printf("%d\n", rev);
    }
   
    getch();
    return 0;  
}

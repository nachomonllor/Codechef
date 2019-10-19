https://www.codechef.com/problems/SPALNUM

#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <vector>


bool esPalindromo(int n) {
    
    int rev = 0;
    int copia = n;
    while(copia > 0){
      
      rev = rev * 10 + (copia % 10);
      
      copia /=10;   
    }   
    
    if(rev == n)return true;
    return false;
}

int sumPalin(int L, int R){
    
    int sum = 0;
    for(int i = L; i <= R; i++) {
        if(esPalindromo(i)){
            sum += i;    
        }
    }
    return sum;
}

int main(){
    
    int T;
    scanf("%d",&T);
     
    for(int i = 0; i < T; i++){
        int L, R;
        scanf("%d %d", &L, &R);
        
        int sum = sumPalin(L, R);
        printf("%d\n", sum);   
    } 
   
    getch();
    return 0;   
}

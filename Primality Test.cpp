https://www.codechef.com/problems/PRB01

#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

bool esPrimo(int n){
    if(n < 2) return false;
    if(n == 2)  return true;
    if(n %2 == 0) return false;
    
    int sqr = (int)sqrt(n);
    for(int i =3; i <=sqr; i+=2){
        if(n % i==0) return false;   
    }
    return true;
}


int main(){
    
    int T;
    scanf("%d",&T);
    for(int i = 0; i < T; i++){
        int n;
        scanf("%d", &n);
        if(esPrimo(n)){
            printf("yes\n");    
        } else{
            printf("no\n");
        }
    }
    
    return 0;   
}

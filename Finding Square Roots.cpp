https://www.codechef.com/problems/FSQRT
#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;


int main(){
    
    int T;
    scanf("%d",&T);
    for(int i = 0; i < T; i++){
        int n;
        scanf("%d", &n);
        printf("%d\n", (int)sqrt(n));
        
    }
    
    return 0;   
}

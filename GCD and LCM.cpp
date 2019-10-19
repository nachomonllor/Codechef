#include<stdio.h>
#include <iostream>

//http://rosettacode.org/wiki/Greatest_common_divisor#Iterative_5
int GCD(int a, int b){
    
    while(b > 0)
	{
		int c = a % b;
		a = b;
		b = c;
	}
	return a;
}

int LCM(int a, int b) {
        
    return (a*b)/GCD(a, b);
}


int main(){
    
    int T;
    scanf("%d", &T);
    
    for(int i =0; i < T; i++)
    {
        int a, b;
        scanf("%d %d", &a, &b);
        
        printf("%d %d\n", GCD(a, b), LCM(a, b));   
        
    }
   
   
   return 0;   
}


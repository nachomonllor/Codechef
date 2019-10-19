https://www.codechef.com/problems/ODDEVENX
#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

int main() {
    
    int n;
    scanf("%d", &n);
    
    int sec[n];
    for(int i =0; i<n; i++) {
      scanf("%d", &sec[i]);   
    }
    
    int pares = 0, impares=0;
    for (int i = 0; i < n; i++) {
        if (sec[i] % 2 == 0)
            pares++;
        
        else
            impares++;
    }
    
    printf("%d\n", abs(pares - impares ));
    
   // system("pause");
    
 return 0;   
}

﻿https://www.codechef.com/problems/ACM14AM1

#include <iostream>
#include <stdio.h>
 
using namespace std;
 
int main() {
 
    int t ;
    scanf("%d", &t);
 
    while (t--){
       
        int n,p;
        scanf("%d %d", &n, &p);
   
        int fitness[n];
        int i;
        for( i =0; i<n; i++) {
            scanf("%d", &fitness[i]);
        }
 
        //int n = 3, p = 1;
        //int[] fitness = {7, 3 ,1};
 
         i = 0;
 
        int answer = 0;
        while (i < n && fitness[i] >= p ) {
            i++;
            answer++;
        }
        // 7 3 1
        printf("%d\n",answer);
    }
   
 return 0;  
}

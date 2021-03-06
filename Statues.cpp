﻿https://www.codechef.com/problems/STATUES
#include <iostream>
#include <stdio.h>
 
using namespace std;
 
int main() {
   
    int test=1;
    while (true) {
        int n;
        scanf("%d", &n);
 
        if (n == 0)
        {
            break;
        }
 
        int est[n];
        int sum =0;
        for(int i =0; i<n; i++) {
           scanf("%d", &est[i]);  
           sum += est[i];
        }
       
        int porHabitacion = sum / n;
 
        int ans = 0;
       
        for(int i =0; i<n; i++){
            if (est[i] > porHabitacion){
                ans += (est[i] - porHabitacion);
            }
        }
 
        printf("Set #%d\n", test);
        printf("The minimum number of moves is %d.\n", ans);
        test++;
    }
   
 return 0;  
}

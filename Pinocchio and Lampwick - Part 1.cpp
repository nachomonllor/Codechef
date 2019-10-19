﻿https://www.codechef.com/problems/PINOCH1
#include <iostream>
#include <stdio.h>

#define ll long long int

using namespace std;

int main() {
    
    int t;
    scanf("%d", &t);
    
    while(t--) {
      int n;
      scanf("%d", &n);
      
      int lens[n];
      for(int i =0; i<n; i++) {
          scanf("%d", &lens[i]);   
      }
      
      ll ans =0;
      
      for(int i =1; i<n; i++) {
         if(lens[i] > lens[i-1]) {
                ans ++;
            }   
        }   
        
        cout << ans << endl;
    }
    
    
    
 return 0;   
}

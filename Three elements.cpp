﻿https://www.codechef.com/problems/ACM14KP5
#include <iostream>
#include <cstdio>
#include <vector>
#include <stack>
#include <queue>
#include <string>
#include <cstring>
#include <map>
#include <cstdlib>
#include <algorithm>
#include <list>
#include <deque>
#include <bitset>
#include <cmath>
#include <functional>
#include <set>
 
int main() {
   
    int t;
    scanf("%d", &t);
   
    int cas=1;
   
    while(t--) {
      int n;
      scanf("%d", &n);
      int arr[n];
      for(int i =0; i<n; i++) {
          scanf("%d", &arr[i]);  
      }  
     
//también se puede hacer ordenando el array y tomando arr[len-1] + arr[len-2] + arr[len-3]
      int max_sum=0;
      for(int i =0; i<n-2; i++) {
         for(int j =i+1; j<n-1; j++) {
            for(int k=j+1; k < n; k++) {
               max_sum = std::max(max_sum, arr[i] + arr[j] + arr[k]);  
            }        
          }
        }
       
       printf("Case %d: %d\n", cas, max_sum );
       
       cas++;    
    }
 
  return 0;
}

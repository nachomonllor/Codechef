﻿https://www.codechef.com/problems/RGPVR101

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
#include <stdio.h>
 
using namespace std;
 
int main() {
   
    int t ;
    scanf("%d", &t);
    while (t--)
    {
        string s ;
        cin >> s;
        int len = s.size();
       
        for(int i = len/2-1; i>=0; i--) {
           printf("%c", s[i]);  
        }
        for(int i =len-1; i>= len/2; i--) {
           printf("%c", s[i]);  
        }
        printf("\n");
       
    }
   
  return 0;  
}

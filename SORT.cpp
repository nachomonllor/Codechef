﻿https://www.codechef.com/problems/SORT
#include <iostream>
#include <stdio.h>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    
    int n;
    scanf("%d",&n);
    std::vector<int> v;
    for(int i =0; i <n; i++) {
      int elem;
      scanf("%d", &elem);
      v.push_back(elem);   
    } 
    
    std::sort(v.begin(), v.end());
    
    for(int i =0; i < n; i++) {
       printf("%d\n", v[i]);   
    }
    
    //system("pause");
    
 return 0;   
}

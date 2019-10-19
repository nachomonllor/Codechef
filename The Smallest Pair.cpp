https://www.codechef.com/problems/SMPAIR

#include<iostream>
#include<cstdio>
#include<stack>
#include<queue>
#include<vector>
#include<algorithm>
#include<cmath>
#include<string>
#include<cstring>
#include <stdio.h>
 
 
using namespace std;
 
int main(){
   
    int T;
    scanf("%d",&T);
   
    while(T--){
   
        int N;
        scanf("%d", &N);
       
        std::vector<int> v(N);
        for(int i = 0; i < N; i++){
            scanf("%d", &v[i]);
        }
       
        sort(v.begin(), v.end());
       
        printf("%d\n", v[0] + v[1]);        
    }
   
   
    return 0;  
}

﻿https://www.codechef.com/problems/ARB
#include <iostream>
#include <stdio.h>
#include <map>

using namespace std;

int main() {
    
    std::map<int,char> m;
    m[0] = 'a';
    m[1] = 'b';
    
    int n;
    scanf("%d", &n);
    cout << m[n] << endl;
    
    //system("pause");
    
    return 0;
}

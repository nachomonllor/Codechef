﻿https://www.codechef.com/problems/PC05
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
 
using namespace std;
 
bool esPrimo(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;
    int sqr = (int)sqrt(n);
 
    for (int i = 3; i <= sqr; i += 2)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
 
int sumarDig(string n)
{
    int sum = 0;
    for (int i = 0; i < n.size(); i++)
    {
        sum +=  (n[i]-'0');
    }
    return sum;
}
 
char buffer[100];
std::string to_string(int k){
    sprintf(buffer, "%d", k);
    return std::string(buffer);
}
 
int main()
{
    int t ;
    scanf("%d", &t);
    while (t--)
    {
        int L,U;
        scanf("%d", &L);
        scanf("%d", &U);
 
        int ans = 0;
        for (int i = L; i <= U; i++)
        {
            if (esPrimo(sumarDig(to_string(i)  )))
            {
                ans++;
            }
        }
        printf("%d\n", ans);
    }
 
}

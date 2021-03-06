﻿https://www.codechef.com/problems/RGPVR102

#include <iostream>
#include<stdio.h>
#include <vector>
#include <math.h>
 
using namespace std;
 
int main() {
    int t;
    scanf("%d", &t);
 
    while (t--)
    {
        int n ;
        scanf("%d", &n);
       
        std::vector<int> wins ;
        for (int i = 0; i < n; i++)  {
            //wins.Add(int.Parse(Console.ReadLine()));
            int elem;
            scanf("%d", &elem);
            wins.push_back(elem);
        }
        std::vector<int> ties ;
        for (int i = 0; i < n; i++) {
            int elem;
            scanf("%d",&elem);
            ties.push_back(elem);
        }
 
        int max_points = 0;
        for (int i = 0; i < n; i++) {
            max_points = std::max(max_points, wins[i] * 3 + ties[i] * 1);
        }
 
        printf("%d\n", max_points);
 
    }
 
   
  return 0;  
}

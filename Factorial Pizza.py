﻿https://www.codechef.com/problems/ALGFACT

t = int(raw_input())

for i in range(0,t):
    n = int(raw_input())
    
    f = 1
    for j in range(2, n+1):
        f *= j
    print f

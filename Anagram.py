﻿https://www.codechef.com/problems/TECH04
t =int(raw_input())

for i in range(0,t):
    input = raw_input().split(" ")
    a = input[0]
    b =input[1]
    da = {}
    for ch in a:
        if da.has_key(ch):
            da[ch]+=1
        else:
            da[ch]=1
    db={}
    for ch in b:
        if db.has_key(ch):
            db[ch]+=1
        else:
            db[ch]=1
    
    ans = "YES"
    if len(a) != len(b):
        ans = "NO"
    else:    
        for key in da:
            if not  db.has_key(key):
                ans = "NO"
                break
            if da[key] != db[key]:
                ans = "NO"
                break
        
    print ans 

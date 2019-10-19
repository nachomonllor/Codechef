https://www.codechef.com/problems/FCTRL2
t = int(raw_input())

for x in range(0,t):
    n = int(raw_input())
    fact = 1
    for i in range(2, n + 1):
        fact *=i
    print fact

https://www.codechef.com/problems/SPCANDY
t = int(raw_input())

while t > 0:
    n, k = map(int,raw_input().strip().split(" "))
    
    if k > 0:
        print str(n/k) + " " + str(n%k)
    else:
        print "0" + " " + str(n)
    
    t-=1

https://www.codechef.com/problems/FLOW017
#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <vector>


int secondLargest(int a, int b, int c)
{
    if (a > b && a > c)
    {
        if (b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
    if (b > a && b > c)
    {
        if (a > c)
        {
            return a;
        }
        else
        {
            return c;
        }

    }
    if (c > a && c > b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }

    }

    return a;
}


int main(){
    
    int T;
    scanf("%d", &T);
    
    for(int i  = 0; i < T; i++){
        
        int a,b,c;
        scanf("%d %d %d", &a, &b, &c);
        
        printf("%d\n", secondLargest(a,b,c));
        
    }
    
    getch();
    return 0;   
}

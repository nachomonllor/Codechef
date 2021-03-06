﻿https://www.codechef.com/problems/DPC101



#include <iostream>
#include <stdio.h>
 
#define ll long long int
 
using namespace std;
 
int CountCarries(ll a, ll b) {
    int carries = 0;
    ll mellevo = 0;
 
    //mientras pueda controlar ambos A y B
    while (a > 0 && b > 0)
    {
        //si me llevo algo hay carries
        if (mellevo > 0)
            carries++;
 
        ll res = a % 10 + b % 10 + mellevo;
 
        //si res es mayor a 9 tiene 2 digitos, por tanto me llevo lo que resta del numero / 10
        if (res > 9)
            mellevo = res / 10;
 
        else
            mellevo = 0;
        a /= 10;
        b /= 10;
    }
 
    while (a > 0)
    {
        if (mellevo > 0)
            carries++;
 
        ll res = a % 10 + mellevo;
 
        if (res > 9)
            mellevo = res / 10;
        else
            mellevo = 0;
 
        a /= 10;
    }
 
    while (b > 0)
    {
        if (mellevo > 0)
            carries++;
 
        ll res = b % 10 + mellevo;
 
        if (res > 9)
            mellevo = res / 10;
        else
            mellevo = 0;
 
        //j--;
        b /= 10;
    }
 
    //si queda algo almacenado de lo que me llevo hay carries
    if (mellevo > 0)
        carries++;
 
    return carries;
 
}
 
int main() {
   
    while(true) {
     
        /*
        string input = Console.ReadLine();
 
        if (input == "0 0")
        {
            break;
        }
 
        string a = input.Split(' ')[0];
        string b = input.Split(' ')[1];
        */
       ll a, b;
       cin >> a;
       cin >> b;
       
       if(a==0 &&b==0){
          break;  
        }
       
 
        int answer = CountCarries(a,b);
 
        if (answer == 0)
        {
            printf("No carry operation.\n");
        }
        else if (answer == 1)
        {
            printf("1 carry operation.\n");
        }
        else
        {
            printf("%d carry operations.\n", answer);
        }
 
 
   
       
    }
   
 return 0;  
}

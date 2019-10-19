https://www.codechef.com/problems/NBSUM
#include <iostream>
#include <stdio.h>
 
#define ll long long int
 
using namespace std;
 
int main() {
   
  int t;
  scanf("%d", &t);
 
    while (t--) {
        ll n;
        scanf("%lld", &n);
        ll sum = 0;
 
        for (ll i = 1; i <= n; i++){
            if (i % 2 == 0){
                sum -= i;
            }
            else{
                sum += i;
            }
        }
 
        printf("%lld\n", sum);
    }
 
 
   
  //system("pause");
   
 return 0;  
}

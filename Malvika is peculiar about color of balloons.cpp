https://www.codechef.com/problems/CHN09

#include <iostream>
#include <stdio.h>

using namespace std;

int main() {
  
  int t;
  scanf("%d", &t);

    while (t--) {
        string s;
        cin >> s;
        int a = 0, b = 0;
        for (int i = 0; i < s.length(); i++)
        {
            if (s[i] == 'a')
            {
                a++;
            }
            if (s[i] == 'b')
            {
                b++;
            }
        }

        printf("%d\n", std::min(a,b));
    }  
    
 return 0;   
}

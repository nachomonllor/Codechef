https://www.codechef.com/problems/CHEFCH

#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

int Count(string s)
{
    

    string a = "";
    string b = "";
    for (int i = 0; i < s.length() / 2 + 1; i++)
    {
        a += "-+";
        b += "+-";
    }

    int conta = 0, contb = 0;

    for (int i = 0; i < s.length(); i++)
    {
        if (s[i] != a[i])
        {
            conta++;
        }
        if (s[i] != b[i])
        {
            contb++;
        }
    }
    return min(conta, contb);
}

int main()
{

    int t;
    scanf("%d", &t);

    while (t--)
    {
        string s ;
        cin >> s;
        cout << Count(s) << endl;
    }
   
	return 0;
}

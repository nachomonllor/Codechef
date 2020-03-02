https://www.codechef.com/problems/PRGIFT
#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

string consecutiveKeven(int arr[], int n, int k)
{
    int cont = 0;	
    for (int i = 0; i < n; i++)
    {
    	cont = 0;
        for(int j = i; j < n; j++) 
		{
        	if(arr[j] % 2 == 0) 
			{
        		cont++;
			}
			if(cont == k) 
			{
				return "YES";
			}
		}
    }
	
	return "NO";
}


int main()
{		
		
    //int[] arr = { 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3 };
    //consecutiveKeven(arr, 10);
		
    int t, n, k;
    scanf("%d", &t);
    

    while (t--)
    {	
        scanf("%d %d", &n, &k);
        int arr[n];
        for (int i = 0; i < n; i++)
        {
			scanf("%d", &arr[i]);
        }
		
        cout << consecutiveKeven(arr, n, k) << endl;
    }	
		
    return 0;
    	
}


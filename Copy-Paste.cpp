https://www.codechef.com/problems/RRCOPY
#include <iostream>
#include <set>
#include <stdio.h>
#include<bits/stdc++.h>

using namespace std;

int main() {
	// your code goes here
	
	int t;
	scanf("%d", &t);
	
	while(t--)	 {
		
		int n;
		scanf("%d", &n);
		//int a[n];
		set<int> s;
		for(int i = 0; i < n; i++) {
			
			int elem;
			scanf("%d", &elem);
			s.insert(elem);
			
		}
		
		cout << s.size() << endl;
	}
	
	return 0;
}

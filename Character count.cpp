﻿https://www.codechef.com/problems/R101
#include <iostream>
#include <stdio.h>

using namespace std;

int main() {
    
  std::string s;
  char ch;
  
  std::getline(std::cin, s);
  cin >> ch;
  
  int answer =0;
  for(int i =0; i<s.size(); i++) {
    if(s[i] == ch) {
        answer++;      
    }
  }
    
  cout << answer << endl;  
  //system("pause");
    
 return 0;   
}

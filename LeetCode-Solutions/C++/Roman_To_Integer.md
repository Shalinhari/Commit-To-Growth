# Roman to Integer

This is the solution for converting roman number to integer value

```cpp
class Solution {
public:
    int romanToInt(string s)
     {
    int num = 0; int prev=0; int current =0;
    for(int i = s.size() - 1; i >= 0; i--)  
    {
       if(s[i]=='I') current = 1;
       if(s[i]=='V') current = 5;
       if(s[i]=='X') current = 10;
       if(s[i]=='L') current = 50;
       if(s[i]=='C') current = 100;
       if(s[i]=='D') current = 500;
       if(s[i]=='M') current = 1000;

       if(current<prev)
       num -=current;
       else
       num +=current;

       prev = current;
    }
        return num;
    }
};
```
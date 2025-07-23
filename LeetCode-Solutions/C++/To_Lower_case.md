# two Sum

This is the solution for to lower case

```cpp
class Solution {
public:
    string toLowerCase(string s) {
        int n = s.length();
        for(int i = 0; i < n; ++i){
            if(s[i] >= 'A' && s[i] <= 'Z') s[i] += 32;
        }
        return s;
    }
};
```
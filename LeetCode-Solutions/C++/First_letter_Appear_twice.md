# First Letter Appear Twice

This is the solution to find first letter appear twice

```cpp
class Solution {
public:
    char repeatedCharacter(string s) {
        int n=s.size();
        int i;
        unordered_map<char,int>map;
        for(i=0;i<n;i++){
            if(map.find(s[i])!=map.end()){
                return s[i];
            }
            map[s[i]];
        }
        return '0';
    }
};
```
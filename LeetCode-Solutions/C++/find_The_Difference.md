# two Sum

This is the solution for finding the find the difference 

```cpp
class Solution {
public:
    char findTheDifference(string s, string t) {
        sort(s.begin(),s.end());
        sort(t.begin(), t.end());
        
        for(int i = 0; i<s.size();i++)
        {
            if(s[i]!=t[i])
            return s[i];
        }
        return t[t.size()-1];
    }
};
```
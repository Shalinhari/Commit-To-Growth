# two Sum

This is the solution for finding the first occurence in the string

```cpp
class Solution {
public:
    int firstUniqChar(string s) 
    {
        unordered_map<char,int> result;

        for(char c : s)
        result[c]++;

        for(int i =0; i<s.length();i++)
        {
            if(result[s[i]]==1)
            return i;
        } 
        return -1;
        
    }
};
```
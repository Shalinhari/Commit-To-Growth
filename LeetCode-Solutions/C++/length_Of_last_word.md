# two Sum

This is the solution for valid parentheses

```cpp
class Solution {
public:
    int lengthOfLastWord(string s) 
    {
        int size = s.size();
        int count = 0;
        for(int i = size - 1; i>=0;i--)
        {
            if(s[i]!= ' ' ) count++;
            else if(count > 0 && s[i]== ' ')
            return count;
        }
        return count;
        
    }
};
```
# two Sum

This is the solution for finding the find is Subsequence

```cpp
class Solution {
public:
    bool isSubsequence(string s, string t) 
    {
        int sPoint = 0;
        int tPoint = 0;

        while( sPoint < s.length() && tPoint < t.length())
        {
            if(s[sPoint] == t[tPoint])
            sPoint++;

            tPoint++;
        }
        return sPoint == s.length();
        
    }
};
```
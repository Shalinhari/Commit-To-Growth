# Longest Comman Prefix

This is the solution for finding out longest comman prefix

```cpp
class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) 
    {
        if( strs.empty()) return "";

        sort(strs.begin() , strs.end());
        string first = strs[0];
        string last = strs[strs.size()-1];
        string result = "";

        for( int i =0; i<first.size();i++)
        {
            if(i<last.size() && first[i]==last[i])
            result = result + first[i];
            else
            break;
        }
        return result;
    }
};
```
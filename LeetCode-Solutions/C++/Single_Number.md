# two Sum

This is the solution for Single Number

```cpp
class Solution {
public:
    int singleNumber(vector<int>& nums)
    {
        unordered_map<int,int> result;
        for(int a : nums)
        result[a]++;
        for(auto b : result)
        if(b.second == 1)
        return b.first;
        return -1;
    }
};
```
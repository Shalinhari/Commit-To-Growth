# The Two Sneaky Numbers Of Digitville

This is the solution for two sneaky number if digitville

```cpp
class Solution {
public:
    vector<int> getSneakyNumbers(vector<int>& nums) 
    {
    vector<int> temp;
    unordered_map<int,int> result;
    for(int i = 0; i<nums.size(); i++)
    {
        result[nums[i]]++;
    }    
    for(auto it : result)
    {
    if(it.second == 2)
    temp.push_back(it.first);
    }
    return temp;

    }
};
```
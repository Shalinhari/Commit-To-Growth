# two Sum

This is the solution for finding the majority Element

```cpp
class Solution {
public:
    int majorityElement(vector<int>& nums) 
    {
        int n = nums.size();
        int maxcount = 0;
        int result = -1;
        for(int i = 0; i<n; i++)
        {
           int current = nums[i];
           int count = 1;
           for(int j = i+1; j<n; j++)
           {
             if(nums[j] == current)
             count++;
           } 
           if(count>maxcount)
           {
            maxcount = count;
            result = current;
           }
        }
        return result;
    }
};
```
# two Sum

This is the solution for Two Sum

```cpp
class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> ans;
        int n = nums.size();
        for( int i =0; i<=n;i++)
        {
         for(int j = i+1;j<=n-1;j++)
         {
           if(nums[i]+nums[j]== target)
           { 
            ans.push_back(i);
            ans.push_back(j);
           }
         }
        }
        return ans;
    }
};
```
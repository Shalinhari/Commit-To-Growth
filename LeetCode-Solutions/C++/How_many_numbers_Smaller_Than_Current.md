# How many numbers are smaller than the current number

This is the solution for numbers that are smaller than the current number

```cpp
class Solution {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        vector<int> ans;
        int n = nums.size();
        int count;
        for(int i=0; i<n; i++)
        {
             count =0;
            for(int j=0; j<n;j++)
            {
                if((j!=i) && (nums[j]<nums[i]))
                {
                    count++;
                }
            }
            ans.push_back(count);
        }
        return ans;
    }
};
```
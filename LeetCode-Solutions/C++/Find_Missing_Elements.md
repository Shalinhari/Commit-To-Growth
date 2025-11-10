# Find Missing Elements

This is the solution for finding the missing elements

```cpp
class Solution {
public:
    vector<int> findMissingElements(vector<int>& nums) 
    {
        vector<int> result;
        sort(nums.begin(), nums.end());
        int currentNumber = nums[0];
        int n = nums.size();
        int i =0;
        while(i<n)
        {
            if(currentNumber == nums[i])
            i++;
            else
            result.push_back(currentNumber);
            currentNumber++;
        }
        return result;
        
    }
};
```
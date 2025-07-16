# Contains Duplicate

This is a solution for checking if a given list of integers contains duplicates.

```cpp
class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
       sort(nums.begin(), nums.end());
       for(int i = 1; i < nums.size(); i++) {
            if(nums[i] == nums[i-1]) 
                return true;
       }
       return false;
    }
};
